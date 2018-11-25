import React, { Component } from 'react';

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
                    <p> 
                    Keeping Safety Smart LLC. is my company and it is an honor and privilege to help educate. The company cornerstone is to 
                    bring the strongest safety education to our community.  We are a program with the Louisiana Bureau of Emergency Medical Services 
                    as well as a national registry company, which means we have met all State of Louisiana requirements including a Medical Director 
                    to teach of our courses. We offer over 25 years of safety education experience.  Please feel free to look at our courses and we 
                    would enjoy the opportunity to help you further your education. 
                    </p>
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