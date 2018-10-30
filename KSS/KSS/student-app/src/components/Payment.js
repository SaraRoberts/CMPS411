import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import PaypalExpressBtn from 'react-paypal-express-checkout';

export class Payment extends React.Component {
    render() {
        const client = {
            sandbox: 'AU7-TZCTcPacLNP7bj74quFlQPLWzG9jlMB8Zqr5m4wnygK-ckrcuV6izspeNmb-su0VXrXWSsjXZAY-',
            production: 'ATt_35Hio2zgeOr0HRxARGxst3ewohkZXzSJ7N4Ds3kwynkon66oriV6zuxLq5RfYW5l64d0dQJoBTAB',
        }
        return (
            <PaypalExpressBtn
                client={client}
                currency={'USD'}
                total={0.01} />
        );
    }
} 