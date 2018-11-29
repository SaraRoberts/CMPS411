import React, { Component } from 'react';
import initialsNav from './images/initialsNav.png';
import './styles/BrandBanner.css';

export class BrandBanner extends Component {
    displayName = BrandBanner.name

    render() {

        return (
            <div id="brandBanner">
                <div id="brandContainer">
                    <div id="brandBannerLeft">
                        <div id="brandLogo">
                            <img src={initialsNav} />
                        </div>
                        <div id="brandMotto">
                            &nbsp;&nbsp;&nbsp;&nbsp;Keep safety smart,<br /> one class at a time!
                        </div>
                    </div>
                    <div id="brandBannerRight">
                        <div id="brandContactInfo">
                            (985) 502 - 9425
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}