import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import k from './images/k.png';
import initialsLogo from './images/initialsLogo.png';
import './styles/GroupPage.css';

export class Group extends Component {
    displayName = Group.name

    render() {
        return (
            <div>
                <div id="groupBanner" alt="Group Safety Classes" />

                <div className="groupRow">
                    <div className="groupColumn" id="groupInfo">
                        <h1>Group Classes</h1>
                        <p>
                            We offer group classes upon request.  If your business is considering employee training
                            in first aid or any other safety courses, Please contact Beckey Smith to discuss pricing,
                            location, and other considerations.
                        </p>
                        <p>
                            Beckey Smith, Owner <br></br>
                            becky@keepingsafetysmart.com<br></br>
                            (985) 502 - 9425<br></br>
                        </p>
                        <p>
                            The maximum class capacity for CPR is one instructor for every nine students which may
                            effect pricing as well as the course selected.
                        </p>
                        Feel free to browse our course catalog availble <Link to='/catalog'>here!</Link>
                    </div>                    
                </div>
                <div className="groupColumn" id="groupImage">
                    <img src={initialsLogo} alt="Group Safety Classes image" />
                </div>
            </div>
        );
    }
}