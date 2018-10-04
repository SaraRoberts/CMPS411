import React, { Component } from 'react';
import { Link, BrowserRouter } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem, NavDropdown, MenuItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './styles/NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <h1> This will be the navbar </h1>
        );
    }
}