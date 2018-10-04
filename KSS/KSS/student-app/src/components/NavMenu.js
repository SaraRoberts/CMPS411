import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem, NavDropdown, MenuItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
//import './styles/NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <ul>
            <li><a href="/">Home  </a></li>
                <li><a href="/group">Group  </a></li>
                <li><a href="/catalog">Catalog  </a></li>
                <li><a href="/contact">Contact  </a></li>
                <li><a href="/login">Login  </a></li>
                <li><a href="/logout">Logout  </a></li>
                <li><a href="/register">Register  </a></li>
                <li> <a href="/myclasses">MyClasses  </a></li >
                <li><a href="/account">Account  </a></li >
                <li><a href="/search">Search  </a></li >
            </ul >
        );
    }
}