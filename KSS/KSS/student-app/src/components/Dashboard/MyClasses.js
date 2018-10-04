import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class MyClasses extends Component {
    displayName = MyClasses.name


    render() {
        return (
            <h1> MyClasses </h1>
        );
    }
}