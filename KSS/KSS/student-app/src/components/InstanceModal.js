import React, { Component } from 'react';
import PaypalExpressBtn from 'react-paypal-express-checkout';
import './styles/InstanceModal.css';
import { Link } from 'react-router-dom';
import toastr from 'toastr'


export class InstanceModal extends Component {

    constructor(props) {
        super(props);
        this.state = {
            enrollmentInfo: {
                userId: 0,         // Dummy value, Cannot be null or empty 
                instanceId: 1,    //  Dummy value, Cannot be null or empty
                bookBought: false,
                paid: false
            }
        };

        toastr.options = {
            positionClass: 'toast-top-center',
            hideDuration: 3000,
            timeOut: 5000,
            newestOnTop: true,

        }
    }

    sleep = (milliseconds) => {
        return new Promise(resolve => setTimeout(resolve, milliseconds))
    }

    bookAndPayLater = (instId) => {
        this.setState({ 
            enrollmentInfo: {
                userId: 0, //  Dummy value, Cannot be null or empty
                instanceId: instId,
                bookBought: false,
                paid: false
            }
        });
        this.state.enrollmentInfo.instanceId = instId;
        console.log(this.state.enrollmentInfo);
        //e.preventDefault();
        fetch('/api/Enrollments/Enrollment', { //Call Api
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            credentials: 'same-origin',
            body: JSON.stringify(this.state.enrollmentInfo) //Pass in the enrollemnt info to the api
        })
            .then(response => {
                if (response.ok) {
                    toastr.success("You are enrolled!"); // Success/failure can be changed to a prettier 
                    this.sleep(1500).then(() => {
                        window.location.href = '/dashboard';  
                    })
                              
                } else if (response.status == 422) {
                    toastr.warning("This class is full");
                } else if (response.status == 423) {
                    toastr.warning("Payment is required for EMT classes");
                } else if (response.status == 424) {
                    toastr.warning("You are already enrolled in this class");
                }          
                else {
                    toastr.warning("Something else went wrong. Instance: " + instId );
                }
            });
    }

    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }


    render() {
        if (!this.props.show) return null

        const onSuccess = (payment) => {
            console.log("Successful: ", payment);
            this.setState({ //set state with the dummy info
                enrollmentInfo: {
                    userId: 1,              
                    instanceId: this.props.modalInstance.instanceId,
                    bookBought: false,
                    paid: true
                }
            });
            //e.preventDefault();
            fetch('/api/Enrollments/Enrollment', { //Call Api
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                credentials: 'same-origin',
                body: JSON.stringify(this.state.enrollmentInfo) //Pass in the enrollemnt info to the api
            })
                .then(response => {
                    if (response.ok) {
                        toastr.success("You are enrolled!"); // Success/failure can be changed to a prettier 
                        this.sleep(1500).then(() => {
                            window.location.href = '/dashboard';
                        })    
                    } else if (response.status == 422) {
                        toastr.warning("This class is full");
                    } else if (response.status == 423) {
                        toastr.error("Payment is required for EMT classes");
                    } else if (response.status == 424) {
                        toastr.warning("You are already enrolled in this class");
                    }
                    else {
                        toastr.warning("Something else went wrong");
                    }
                });
        };

        //Output in browser console on cancel (closing the window)
        const onCancel = (data) => {
                console.log('Canceled', data);
        };

        //If an error is encountered in the API or it crashes
        const onError = (err) => {
                console.log("Failure: ", err);
        };

        // checks EMT
        if (this.props.modalInstance.courseCategory != "EMT") {
            var instId = this.props.modalInstance.instanceId;
            var payLater = (
                <h5>or <span id="payLater" onClick={() => this.bookAndPayLater(instId)}> Book and Pay Later </span></h5>
            );
        }

        const client = {
                //For testing, use sandbox, for live, use Production. The 'env' variable will also need to be changed in the PayPalExpressBtn element below
                sandbox: 'AU7-TZCTcPacLNP7bj74quFlQPLWzG9jlMB8Zqr5m4wnygK-ckrcuV6izspeNmb-su0VXrXWSsjXZAY-',
                production: 'ATt_35Hio2zgeOr0HRxARGxst3ewohkZXzSJ7N4Ds3kwynkon66oriV6zuxLq5RfYW5l64d0dQJoBTAB'
        };

        if (this.props.modalInstance.courseCategory == "CAR") {
        return (
                <div id="modalBack">
                    <div id="modal-left" />
                    <div id="modal-right" onClick="">
                        <span id="closeButton" onClick={(e) => { this.onClose(e) }} onMouseOver="">
                            X
                    </span>
                        <h2>{this.props.modalInstance.courseName}</h2>
                        <h4>Instructor: {this.props.modalInstance.instructorName}</h4>
                        
                        <p>
                            We offer assistance with car seat installation and safety free of charge to make sure
                            your little ones ride safely. Please contact Nicole Dufrene for more information!
                        </p>
                        <p>
                            Nicole Dufrene, EMR <br />
                            nicoledufrene0301@gmail.com<br></br>
                        </p>
                        View a list of locations <Link id="carLink" to='/carseatsafety'>here!</Link>
                    </div>
                </div>
            );
        }
        else {
            return(
                <div id="modalBack">
                    <div id="modal-left" />
                    <div id="modal-right" onClick="">
                        <span id="closeButton" onClick={(e) => { this.onClose(e) }} onMouseOver="">
                            X
                    </span>
                        <h2>{this.props.modalInstance.courseName}</h2>

                        <h4>Instructor: {this.props.modalInstance.instructorName}</h4>
                        <h4>{this.props.modalInstance.startDate}</h4>
                        <h4>{this.props.modalInstance.locationName}<br />
                            {this.props.modalInstance.locationCity}, {this.props.modalInstance.locationState} {this.props.modalInstance.locationZip}
                        </h4>
                        <h4>Price: ${this.props.modalInstance.price}</h4>

                        <h5 id="payMessage">Click to pay with PayPal and Book Class.</h5>

                        <PaypalExpressBtn
                            env={'sandbox'} //change this to 'production' to complete REAL transactions
                            client={client}
                            currency={'USD'}

                            total={this.props.modalInstance.price} //change this to adjust price

                            //output handlers
                            onSuccess={onSuccess}
                            onError={onError}
                            onCancel={onCancel}
                        />
                        {payLater}
                    </div>
                </div>
            );
        }
    }
}