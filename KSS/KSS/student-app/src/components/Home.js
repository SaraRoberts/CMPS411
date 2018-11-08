import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import home1 from './images/home1.jpg';
import logo from './images/logo.png';
import emtImage from './images/EMTImage.jpeg';
import emrImage from './images/EMRImage.jpeg';
import bbsImage from './images/BBSImage.jpeg';
import cssImage from './images/CSSImage.jpeg';
import aquImage from './images/AQUImage.jpeg';
import './styles/HomePage.css';

export class Home extends Component {
    displayName = Home.name
    render() {
        return (
            <div id="main-container">
                <div id = "nestedImage-container">
                    <img id="topImage" src={home1} alt="Home1" />
                </div>
                <div id="centered-logo-container">
                    <img id="nested-logo" src={logo} alt="Logo" />
                </div>

                <div id="banner-container">
                    <p id="banner-title">Keep safety smart one class at a time</p>
                    <p id="banner-text">Keeping Safety Smart LLC. is my company and it is an honor and privilege to help educate. The company 
                        cornerstone is to bring the strongest safety education to our community.  We are a program with the 
                        Louisiana Bureau of Emergency Medical Services as well as a national registry company, which means we 
                        have met all State of Louisiana requirements including a Medical Director to teach our courses. We 
                        offer over 25 years of safety education experience.   
                    </p>
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
                        
                    <div className="course">
                        <img className="course-image" src={aquImage} />
                        <h2>AQU</h2>
                        <p>These courses teaches
                            applicable safety practices for individuals such as swim coaches and lifeguard
                            instructors and even professional resuers.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={bbsImage} />
                        <h2>BBS</h2>
                        <p>Babysitting can sometimes be difficult, but BBS courses teach babysitting skills
                            such as leadership, keeping children safe, and helping kids to behave to anyone
                            who wants to learn or even grow a babysitting business.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={cssImage} />
                        <h2>CSS</h2>
                        <p>Learn how to properly conduct cild safety seat checks, and be informed on the best
                            way to utilize and understand seat belts and child restraint systems while in 
                            motorized vehicles.
                        </p>
                    </div>
                </div>
            </div>
        );
    }
}