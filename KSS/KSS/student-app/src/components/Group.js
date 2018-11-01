import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import groups1 from './images/groups1.jpg';
import k from './images/k.png';
import './styles/GroupPage.css';

export class Group extends Component {
    displayName = Group.name

    render() {
        return (
            <div id="page">
                <div id="main-container">

                    <img id="headerImage" src={groups1} alt="Groups1" />

                    <div class="tworow">
                        <div class="twocolumn">
                            <img id="main-image" src={k} alt="K" />
                        </div>
                        <div class="twocolumn" id="info">
                            <h1>Interested in enrolling as a group?</h1>
                            <p> 
                                Keeping Safety Smart offers group classes which can be made available upon request.  If you represent 
                                a business considering training its employees in first aid and other first responder
                                courses, please contact us to discuss pricing, location, and other considerations.  
                            </p>
                            <p>
                                The maximum class capacity for CPR is one instructor for every nine students which may
                                effect pricing as well as the course selected.
                            </p>
                            <p>
                                Please contact Beckey Smith for more information and quotes for prices. Thank you for your interest!
                            </p>
                            <p>
                                Feel free to browse the many courses we have to offer <a href="/catalog">here!</a>
                            </p>
                            <br></br>
                            <p>
                                Beckey Smith, Owner <br></br>
                                becky@keepingsafetysmart.com<br></br>
                                (985) 888 - 8888<br></br>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}