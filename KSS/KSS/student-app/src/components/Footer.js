import React, { Component } from 'react';
import ReactDom from 'react-dom';
import facebook from './images/Facebook.png';
import email from './images/Email.png';
import './styles/Footer.css';


export class Footer extends React.Component {
    displayName = Footer.name

    render() {
        return (
            <footer>
                <div className="main-container">
                    <div className="footer-navigation">
                        <h3><a href="#">Keeping Safety Smart</a></h3>
                        <p>
                            Ms Beckey Smith, Owner <br />
                            beckey@keepingsafetysmart.com <br />
                            (985) 888-8888 <br />
                            Cell: (985) 888-8888 <br />
                            <a href="\">
                                www.keepingsafetysmart.com
                            </a>    
                        </p>
                        <p className="company-name">KSS © 2018 </p>
                        <div className="social">
                            <img className="social-icons" src={email} />
                        </div>
                        <div className="social">
                            <a href="https://www.facebook.com/kssbeckey/">
                                <img className="social-icons" src={facebook} />
                            </a>
                        </div>
                    </div>
                </div>
            </footer>
        );
    }
}