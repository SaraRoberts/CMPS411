import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import groups1 from './images/groups1.jpg';
import k from './images/k.png';

export class Group extends Component {
    displayName = Group.name


    render() {
        return (
            <div id="page">
                <div id="main-container">

                    <img id="topImage" src={groups1} alt="Groups1" />

                    <div class="tworow">
                        <div class="twocolumn">
                            <img src={k} alt="K" />
                        </div>
                        <div class="twocolumn">
                            <h2>Interested in scheduling a group class?</h2>
                            <p> 
                                Keeping Safety Smart offers group classes available on request.  If you represent 
                                a business considering training its employees in first aid and other first responder
                                courses, please contact us to discuss pricing, location, and other considerations.  
                            </p>
                            <br></br>
                            <p>
                                The maximum class capacity for CPR is one instructor for every nine students which may
                                effect pricing as well as the course selected.
                            </p>
                            <br></br>
                            <p>
                                Please contact Beckey Smith for information and quotes for prices.
                            </p>
                            <br></br>
                            <p>
                                Beckey Smith, Owner <br></br>
                                Email: becky@keepingsafetysmart.com<br></br>
                                Phone: (985) 888 - 8888<br></br>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}