import React, { Component } from 'react';
import { MenuItem, Nav, NavItem } from 'react-bootstrap';
import Modal from 'react-modal';
import { LinkContainer } from 'react-router-bootstrap';
import { Button } from 'semantic-ui-react';
import { LoginModal } from './LoginModal';
import './styles/NavMenu.css';

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
        if (!this.props.loginState.loggedIn) {
            var rightNav = (
                <div id="register-button">
                    <Button id="sign-in-button" onClick={
                        () => this.showModal()}>Sign Up / Login
                    </Button>
                </div>
            );
                } else rightNav = (
                    <div id="register-button">
                        <LinkContainer to={'/dashboard'}>
                            <MenuItem className="left-button-divider">Dashboard</MenuItem>
                        </LinkContainer>
                        <LinkContainer to={'/logout'}>
                            <NavItem>Logout</NavItem>
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
                                    <NavItem className="left-button-divider">Home</NavItem>
                                </LinkContainer>
                                <LinkContainer to={'/catalog'}>
                                    <NavItem>Catalog</NavItem>
                                </LinkContainer>
                                <LinkContainer to={'/group'}>
                                    <NavItem>Groups</NavItem>
                                </LinkContainer>
                            </div>
                            {rightNav}
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