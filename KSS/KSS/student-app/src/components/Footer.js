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
                            beckey@keepingsafetysmart.com <br />
                            (985) 502 - 9425 <br />
                            <a href="\">www.keepingsafetysmart.com</a>    
                        </p>
                        <p>KSS © 2018 </p>
                    </div>
                    <div id="social-icons">
                        <img src={emailLink} />
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