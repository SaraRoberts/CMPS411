import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem, NavDropdown, MenuItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './styles/NavMenu.css';
import Modal from 'react-modal';
import { LoginModal } from './LoginModal'
import { Button } from 'semantic-ui-react';

Modal.setAppElement(document.getElementById('root'));

export class NavMenu extends Component {
    displayName = NavMenu.name
    constructor(props) {
        super(props);
        this.state = {
            modalInstance: null
        };
    }

    showModal = () => {
        if (!this.state.show) {
            this.setState({
                ...this.state,
                show: !this.state.show,
            })
        }
        else {
            this.setState({
                ...this.state,
                show: !this.state.show,
            })
        }
    }

    render() {
        if (!this.props.loggedIn) {
            var rightNav = (
                <div id="register-button">
                    <LinkContainer to={'/register'}>
                        <NavItem className="left-button-divider">Sign Up</NavItem>
                    </LinkContainer>
                    <LinkContainer to={'/login'}>
                        <NavItem>Login</NavItem>
                    </LinkContainer>
                </div>
            );
                } else rightNav = (
                    <div id="register-button">
                        <LinkContainer to={'/account'}>
                            <MenuItem className="left-button-divider">My Account</MenuItem>
                        </LinkContainer>
                        <LinkContainer to={'/logout'}>
                    <NavItem> Logout </NavItem>
                    </LinkContainer>
            </div>
            );
        return (
            <header>
                <div className="container">
                    <div className="navmenu">
                        <Nav>
                            <div id="basic-nav">
                                <LinkContainer to={'/'} exact>
                                    <NavItem className="left-button-divider"> Home </NavItem>
                                </LinkContainer>
                                <LinkContainer to={'/catalog'}>
                                    <NavItem> Catalog </NavItem>
                                </LinkContainer>
                                <LinkContainer to={'/group'}>
                                    <NavItem> Group </NavItem>
                                </LinkContainer>
                            </div>
                            <div className="dropdown">
                                <NavDropdown eventKey={5} title="Dashboard" >
                                    <div className="dropdown-content">
                                        <LinkContainer to={'/myclasses'}>
                                            <MenuItem className="first-item">My Classes</MenuItem>
                                        </LinkContainer>
                                        <LinkContainer to={'/search'}>
                                            <MenuItem className="menu-item">Class Search</MenuItem>
                                        </LinkContainer>
                                    </div>
                                </NavDropdown>
                            </div>
                            {rightNav}
                            <Button onClick={
                                () => this.showModal()}>Book Now!>Login
                            </Button>
                        </Nav>
                    </div>
                    <LoginModal
                        show={this.state.show}
                        onClose={this.showModal}
                        modalInstance={this.state.modalInstance}
                    />
                </div>
            </header>
        );
    }
}