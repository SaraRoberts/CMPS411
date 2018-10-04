import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Contact extends Component {
    displayName = Contact.name


    render() {
        return (
            <h1> Contact </h1>
        );
    }
}