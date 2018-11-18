import React, { Component } from 'react';
import PaypalExpressBtn from 'react-paypal-express-checkout';
import './styles/InstanceModal.css';


export class InstanceModal extends Component {

    constructor(props) {
        super(props);
    }


    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }


    render() {
        if (!this.props.show) return null
        const onSuccess = (payment) => {
            console.log("Successful: ", payment);
        };

        //Output in browser console on cancel (closing the window)
        const onCancel = (data) => {
                console.log('Canceled', data);
        };

        //If an error is encountered in the API or it crashes
        const onError = (err) => {
                console.log("Failure: ", err);
        };

        const client = {
                //For testing, use sandbox, for live, use Production. The 'env' variable will also need to be changed in the PayPalExpressBtn element below
                sandbox: 'AU7-TZCTcPacLNP7bj74quFlQPLWzG9jlMB8Zqr5m4wnygK-ckrcuV6izspeNmb-su0VXrXWSsjXZAY-',
                production: 'ATt_35Hio2zgeOr0HRxARGxst3ewohkZXzSJ7N4Ds3kwynkon66oriV6zuxLq5RfYW5l64d0dQJoBTAB'
        };

        return (
            <div id="modalBack">
                <div id="modal-left"></div>
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
                    
                    <h5>Click to pay with PayPal and Book Class.</h5>

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
                    <h5>or <a href="/">Book and Pay Later</a></h5>
                </div>
            </div>
        );
    }
}