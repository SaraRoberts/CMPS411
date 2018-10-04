import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Group extends Component {
    displayName = Group.name


    render() {
        return (
            <h1> Group </h1>
        );
    }
}