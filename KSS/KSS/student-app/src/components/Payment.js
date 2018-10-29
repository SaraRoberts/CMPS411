import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import PayPalButton from 'react-paypal-button'

export class Home extends Component {
    render(){
        return (
            <PayPalButton
                //Uncomment when we move into production
                //env='production'
                env = 'sandbox'
                sandboxID='abcdef123456'
                //Uncomment this when we move into production
                //productionID='abcdef123456'
                amount={0.01}
                currency='USD'
                commit={true}
            />
        );
    }
}