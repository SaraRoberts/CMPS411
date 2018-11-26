import React, { Component } from 'react';
import emailLink from './images/emailLink.png';
import facebookLogo from './images/facebookLogo.png';
import instagramLogo from './images/instagramLogo.png';
import twitterLogo from './images/twitterLogo.png';
import './styles/Footer.css';


export class Footer extends Component {
    displayName = Footer.name

    render() {
        return (
            <footer>
                <div className="content-container">
                    <div id="footer-contact">
                        <a href="\">
                            <h3>Keeping Safety Smart</h3>
                        </a>
                        <p>
                            Ms Beckey Smith, Owner <br />
                            <a href="mailto:beckey@keepingsafetysmart.com">
                                beckey@keepingsafetysmart.com <br />
                            </a>
                            (985) 888-8888 <br />
                            Cell: (985) 888-8888 <br />
                            <a href="\">www.keepingsafetysmart.com</a>    
                        </p>
                        <p>KSS © 2018 </p>
                    </div>
                    <div id="social-icons">
                        <a href="mailto:beckey@keepingsafetysmart.com">
                            <img src={emailLink} />
                        </a>
                        <a href="https://www.facebook.com/kssbeckey/">
                            <img src={facebookLogo} />
                        </a>
                        <a href="">
                            <img src={twitterLogo} />
                        </a>
                        <a href="">
                            <img src={instagramLogo} />
                        </a>
                    </div>
                </div>
            </footer>
        );
    }
}