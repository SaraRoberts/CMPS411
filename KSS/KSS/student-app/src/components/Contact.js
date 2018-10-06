import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Contact extends Component {
    displayName = Contact.name


    render() {
        return (
            <div>
                <h1> Contact </h1>
                <p> Here, we put contact information for the business and any relevant info that would be useful to the user</p>
            </div>
        );
    }
}