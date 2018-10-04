import React, { Component } from 'react';
import ReactDom from 'react-dom';


export class Footer extends React.Component {
    displayName = Footer.name


    render() {
        return (
            <footer>
                <div class="row">
                    <div class="col-md-4 col-sm-6 footer-navigation">
                        <h3><a href="#">Keeping Safety Smart</a></h3>
                        <p class="links">
                            <ul>
                                <li>Spencer Shaw</li>
                                <li>Donald Vicknair</li>
                                <li>Weston Arnold</li>
                                <li>Sara Roberts</li>
                            </ul></p>
                        <p class="company-name">KSS © 2018 </p>
                    </div>
                    <div class="clearfix visible-sm-block"></div>
                    <div class="col-md-4 footer-about">
                        <h4>About this project</h4>
                        <p> Test Footer </p>
                    </div>
                </div>
            </footer>
        );
    }
}