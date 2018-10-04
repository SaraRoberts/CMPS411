import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Home extends Component {
    displayName = Home.name


    render() {
        return (
            <h1> A test </h1>
        );
    }
}