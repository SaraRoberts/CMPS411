import React, { Component } from 'react';
import './styles/InstanceModal.css';

export class LoginModal extends Component {
    constructor(props) {
        super(props);
    }

    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }

    render() {
        if (!this.props.show) return null

        return (
            <div id="modalBack">
                <div id="login">
                    <h1>Login</h1>
                </div>
                <div id="sign-up" onClick="">
                    <h1>Sign up</h1>
                </div>
            </div>
        );
    }
}