import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Contact extends Component {
    displayName = Contact.name


    render() {
        return (
        <div id="page">
                <div id="main-container">
                    <h1>Keeping Safety Smart</h1>
                    <h2> About Us </h2>
                        <p> Keeping Safety Smart was founded October 17th, 2018 by Beckey Smith. Etc.</p> 
                    <h2> Mission Statement</h2>
                        <p> Teaching life saving tools to all. Placeholder. </p>
                    <h2> Contact</h2>
                        <p>
                        Beckey Smith, Owner <br></br>
                        becky@keepingsafetysmart.com<br></br>
                        (985) 888 - 8888<br></br>
                        </p>
                </div>
            </div>
        );
    }
}