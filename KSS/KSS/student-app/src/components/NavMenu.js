import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem, NavDropdown, MenuItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './styles/NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name

    render() {
        return (
            <header>
                <div className="container">
                    <div class="navmenu">
                        <Nav>
                            <NavItem eventKey={1} href="/"> Home </NavItem>
                            <NavItem eventKey={2} href="/catalog"> Catalog </NavItem>
                            <NavItem eventKey={3} href="/group"> Group </NavItem>
                            <NavItem eventKey={4} href="/contact"> Contact </NavItem>
                            <NavItem eventKey={5} href="/payment"> Payment </NavItem>

                            <div class="dropdown">
                            <NavDropdown eventKey={5} title="Dashboard" >
                                <div class="dropdown-content">
                                <MenuItem eventKey={5.1} href="/myclasses"> My Classes </MenuItem>
                                <MenuItem eventKey={5.2} href="/search"> Class Search </MenuItem>
                                <MenuItem eventKey={5.3} href="/account">My Account</MenuItem>
                                </div>
                            </NavDropdown>
                            </div>
                            <div id="register-button">
                                <NavItem eventKey={6} href="/register"> Register </NavItem>
                                <NavItem eventKey={7} href="/login"> Login </NavItem>
                                <NavItem eventKey={8} href="/logout"> Logout </NavItem>
                            </div>
                        </Nav>
                    </div>
                </div>
            </header>
        );
    }
}