import React, { Component } from 'react';
import Modal from 'react-modal';
import { Link } from 'react-router-dom';
import { LoginModal } from './LoginModal';
import './styles/NavMenu.css';
import initialsNav from './images/initialsNav.png';

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
                <div className="link signup-login" onClick={
                    () => this.showModal()}>
                    <span>Sign Up / Login</span>
                </div>
            );
        } else rightNav = (
            <div>
                <Link to={'/dashboard'}>
                    <div className="link dashboard">
                            Dashboard
                    </div>
                </Link>
                <Link to={'/logout'}>
                    <div className="link">
                        Logout
                    </div>
                </Link>
            </div>
            );
        return (
            <header>
                <div className="container">
                    
                    <div className="topnav">
                        <Link to={'/'} exact>
                            <div className="logo">
                                <img src={initialsNav} />
                            </div>
                        </Link>
                        <Link to={'/catalog'}>
                            <div className="link">
                                Catalog
                            </div>
                        </Link>
                        <Link to={'/group'}>
                            <div className="link">
                                Groups
                            </div>
                        </Link>
                        <div className="rightNav">
                            {rightNav}
                        </div>
                    </div>
                </div>
                <LoginModal
                    show={this.state.show}
                    onClose={this.showModal}
                    modalInstance={this.state.modalInstance}
                />
            </header>
        );
    }
}