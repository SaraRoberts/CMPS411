import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import groupPage from './images/groupPage.jpg';
import k from './images/k.png';
import './styles/GroupPage.css';

export class Group extends Component {
    displayName = Group.name

    render() {
        return (
            <div id="main-container">

                <img id="headerImage" src={groupPage} alt="Groups1" />

                <div class="tworow">
                    <div class="twocolumn">
                        <img id="main-image" src={k} alt="Group Safety Classes image" />
                    </div>
                    <div class="twocolumn" id="info">
                        <h1>Group Classes</h1>
                        <p> 
                            We offer group classes upon request.  If your business is considering employee training
                            in first aid or any other safety courses, Please contact Beckey Smith to discuss pricing,
                            location, and other considerations.  
                        </p>
                        <p>
                            Beckey Smith, Owner <br></br>
                            becky@keepingsafetysmart.com<br></br>
                            (985) 888 - 8888<br></br>
                        </p>
                        <p>
                            The maximum class capacity for CPR is one instructor for every nine students which may
                            effect pricing as well as the course selected.
                        </p>
                        Feel free to browse our course catalog availble <a href="/catalog">here!</a>
                    </div>
                </div>
            </div>
        );
    }
}