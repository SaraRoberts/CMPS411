import React, { Component } from 'react';
import aquImage from './images/AQUImage.jpeg';
import bbsImage from './images/BBSImage.jpeg';
import cssImage from './images/CSSImage.jpeg';
import emrImage from './images/EMRImage.jpeg';
import emtImage from './images/EMTImage.jpeg';
import home1 from './images/home1.jpg';
import logo from './images/logo.png';
import './styles/HomePage.css';

export class Home extends Component {
    displayName = Home.name
    render() {       
        return (
            <div>
                <div id="homeBanner">
                    <img id="nested-logo" src={logo} alt="Keeping Safety Smart logo" />
                </div>
                <div id="banner-container">
                    <p id="banner-title">Keep safety smart, one class at a time!</p>
                    <p id="banner-text">The cornerstone of Keeping Safety Smart is bringing our community the best safety
                        education. It is our honor and privilege to help educate our community.  We are a program with the
                        Louisiana Bureau of Emergency Medical Services and a national registry company, meeting all
                        Louisiana requirements. We also offer over 25 years of safety education experience.   
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
                        <p>CPR is a medical procedure involving specific chest
                            compression, performed in an attempt to bring back
                            blood circulation and breathing of a person suffering
                            cardiac arrest.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={emrImage} />
                        <h2>EMR</h2>
                        <p> In case of a medical emergency, learn techniques and procedures for 
                            helping others in need of immediate attention and treating minor wounds.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={aquImage} />
                        <h2>AQU</h2>
                        <p>These courses teach
                            applicable safety practices for individuals such as swim coaches, lifeguard
                            instructors, and even professional rescuers.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={bbsImage} />
                        <h2>BBS</h2>
                        <p>Babysitting can be difficult, but BBS courses teach babysitting skills,
                            such as leadership, child safety, and child behavoir to anyone
                            with a desire to learn or growing a babysitting business.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={cssImage} />
                        <h2>CSS</h2>
                        <p>Learn how to properly conduct child safety seat checks and be informed on the best
                            way to utilize and understand seat belts and child restraint systems while in 
                            motorized vehicles.
                        </p>
                    </div>
                </div>
            </div>
        );
    }
}