import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Catalog extends Component {
    displayName = Catalog.name


    render() {
        return (
            <h1> Catalog. This shows non-users class offerings and info like what is CPR, EMT, etc. </h1>
        );
    }
}