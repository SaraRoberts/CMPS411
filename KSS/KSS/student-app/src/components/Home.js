import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import home1 from './images/home1.jpg';
import logo from './images/logo.png';
import emtImage from './images/EMTImage.jpeg';
import emrImage from './images/EMRImage.jpeg';
import './styles/HomePage.css';

export class Home extends Component {
    displayName = Home.name
    render() {
        return (
            <div>
                <img id="topImage" src={home1} alt="Home1" />
                <img id="logo" src={logo} alt="Logo" />

                <div id="banner-container">
                    <p id="banner-title">Keep safety smart one class at a time</p>
                    <p id="banner-text">Choose from any of the course offerings below to begin enhancing your emergency medical skills!</p>
                </div>

                <div>
                    <div className="course">
                        <img className="course-image" src={emtImage} />
                        <h2>EMT</h2>
                        <p>Interested in becoming an EMT? An EMT is a specially trained
                           technician certified to provide basic emergency services
                           before and during transportation to a hospital.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={home1} />
                        <h2>CPR</h2>
                        <p>Learn CPR, a medical procedure involving specific compression
                           of a patient's chest, performed in an attempt to bring back
                           the blood circulation and breathing os a person who has suffered
                           cardiac arrest
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={emrImage} />
                        <h2>EMR</h2>
                        <p> In case of a medical emergency, learn techniques and procedures for 
                            helping others who are in need of attention and treating minor wounds
                        </p>
                    </div>
                </div>
            </div>
        );
    }
}