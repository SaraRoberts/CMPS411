import React, { Component } from 'react';
import { Image } from 'semantic-ui-react';
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

    constructor(props) {
        super(props);
        this.state = { staffs: [], loading: true, featuredStaffId: 1 };
    }

    componentDidMount() {
        document.title = "Keeping Safety Smart | Home";
        fetch('/api/Staffs', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ staffs: data, loading: false, featuredStaffId: Math.floor(Math.random() * data.length) });
            });
    }

    static renderStaff(staffs, featuredStaffId) {
        return (
            <div class="staffBox">
                <div class="staffBoxItem">
                    <Image src={staffs[featuredStaffId].picture} max width="150" />
                </div>
                <div class="staffBoxItem">
                    <p>{staffs[featuredStaffId].bio}</p>
                </div>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderStaff(this.state.staffs, this.state.featuredStaffId);

        return (
            <div>
                <div id="homeBanner">
                    <img id="nested-logo" src={logo} alt="Keeping Safety Smart logo" />
                </div>
                <div id="banner-container">
                    <br/>
                    <p id="banner-title">Keep safety smart, one class at a time!</p>
                    <br />
                    <p id="banner-text">The cornerstone of Keeping Safety Smart is bringing our community the best safety
                        education. It is our honor and privilege to help educate our community.  We are a program with the
                        Louisiana Bureau of Emergency Medical Services and a national registry company, meeting all
                        Louisiana requirements. We also offer over 25 years of safety education experience.   
                    </p>
                    <br />
                </div>
                <br /><br /><br /><br />
                <div>
                    <div className="course">
                            <img className="course-image" src={emtImage} />
                            <h2>Emergency Medical Technician</h2>
                            <p> Become an EMT, or a specially trained medical
                                technician certified to provide basic emergency services
                                before and during transportation to a hospital.
                            </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={home1} />
                        <h2>CPR</h2>
                        <p> Learn CPR, a medical procedure involving specific chest
                            compression, performed in an attempt to bring back
                            blood circulation and breathing of a person suffering
                            cardiac arrest.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={emrImage} />
                        <h2>Emergency Medical Responder</h2>
                        <p> In case of a medical emergency, learn techniques and procedures for 
                            helping others in need of immediate attention and treating minor wounds.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={aquImage} />
                        <h2>Aquatic Rescue</h2>
                        <p> Learn how to save lives during aquatic emergencies. These courses teach
                            applicable safety practices for lifeguards, swim coaches, lifeguard
                            instructors, and professional rescuers.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={bbsImage} />
                        <h2>Babysitting</h2>
                        <p> Babysitting can be difficult, but these courses teach babysitting skills,
                            such as child safety, leadership, and child behavoir to anyone
                            with a desire provide childcare or grow a babysitting business.
                        </p>
                    </div>
                    <div className="course">
                        <img className="course-image" src={cssImage} />
                        <h2>Car Seat Safety</h2>
                        <p> Learn how to properly conduct child safety seat checks and be informed on the best
                            way to utilize and understand seat belts and child restraint systems while in 
                            motorized vehicles.
                        </p>
                    </div>
                </div>
                <br /><br /><br /><br />
                <div id="banner-container">
                    <br />
                    <p id="banner-title">Featured Instructor</p>
                    <br />
                    <div className="staffDiv">
                        {contents}
                    </div>
                    <br /><br /><br />
                </div>
            </div>
        );
    }
}