import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Account extends Component {
    displayName = Account.name


    render() {
        return (
            <h1> Account </h1>
        );
    }
}