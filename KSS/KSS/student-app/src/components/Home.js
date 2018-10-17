import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import home1 from './images/home1.jpg';
import './styles/HomePage.css';

export class Home extends Component {
    displayName = Home.name
    render() {
        return (
            <div>
                <img className="topImage" src={home1} alt="Home1" />
                <div></div>
            </div>
        );
    }
}