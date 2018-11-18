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
                <div id="modal-right">
                    <input type="button" className="close btn-link"
                        value="Cancel"
                        onClick={(e) => { this.onClose(e) }}
                    />
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
                </div>
            </div>
        );
    }
}