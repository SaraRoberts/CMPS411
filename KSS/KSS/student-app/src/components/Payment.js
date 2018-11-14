import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import PaypalExpressBtn from 'react-paypal-express-checkout';

export class Payment extends React.Component {
    displayName = Payment.name
    constructor(props) {
        super(props);
        this.handleClick = this.handleClick.bind(this); 
        this.state = {
            price: ""
            
        };
        
    }

    handleClick(e) { //Click event that works. Need to put this on the paypal button
        e.preventDefault();
        console.log('The button was clicked.');
         this.setState({
            ...this.state,
            price: 10
        });
    };

    componentDidMount() { // May need to use this later if you need something to mount


    }
  
    render() {     
     
        //Output in browser console on success
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
            production: 'ATt_35Hio2zgeOr0HRxARGxst3ewohkZXzSJ7N4Ds3kwynkon66oriV6zuxLq5RfYW5l64d0dQJoBTAB',           
        };

        //renders the button with the following attributes. The only value needing to changed from time to time is 'env' and 'cost'
        return (
            <div>
                <PaypalExpressBtn
                env={'sandbox'} //change this to 'production' to complete REAL transactions
                client={client}
                currency={'USD'}

                    total={this.state.price} //change this to adjust price

                //output handlers
                onSuccess={onSuccess}
                onError={onError}
                onCancel={onCancel}  
                                  
                />              
                
                <button onClick={this.handleClick}> 
                    Test Click Event
                </button>
            </div>                        
        );
    }
} 