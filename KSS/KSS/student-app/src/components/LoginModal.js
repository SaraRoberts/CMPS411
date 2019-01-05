import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './styles/LoginModal.css';
//import './User/users.css';

export class LoginModal extends Component {
    //Constructor
    constructor(props) {
        super(props);
        //These variables  are used for Sign Up information
        this.state = {
            credentials: {
                email: "",
                password: ""
            }
        };
        //This initiates the methods to the Modal object
        this.handleChangeLogin = this.handleChangeLogin.bind(this);
        this.handleSubmitLogin = this.handleSubmitLogin.bind(this);
    }

    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }

    //Handles Change for login
    handleChangeLogin = e => {
        var credentials = {
            ...this.state.credentials,
            [e.target.name]: e.target.value
        };
        this.setState({ credentials: credentials });
    }

    //Handles Submit
    handleSubmitLogin = e => {
        e.preventDefault();
        fetch('/api/account/login', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            credentials: 'same-origin',
            body: JSON.stringify(this.state.credentials)
        })
            .then(response => {
                if (response.ok) {
                    window.location.href = '/dashboard';
                } else {
                    alert('Login failed!!!!');
                }
            });

        //Sets state based on information provided in login
        this.setState({
            credentials: {
                email: "",
                password: ""
            }
        });
    }

    render() {
        if (!this.props.show) return null;
        return (
            <div id="modalBackLogin">
                <div id="loginLogin">
                    <span id="closeButtonLogin" onClick={(e) => { this.onClose(e); }} onMouseOver="">
                        X &nbsp;&nbsp;
                    </span>
                    <div>
                        <div id="loginModalForm">
                            <h1>Login</h1>
                            <hr />
                            <br />
                            <form onSubmit={this.handleSubmitLogin} method="post">
                                <div>
                                    <label>Email</label>
                                    <div>
                                        <div>
                                            <input type="text" className="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChangeLogin} />
                                        </div>
                                    </div>
                                </div>
                                <div>
                                    <label>Password</label>
                                    <div>
                                        <div>
                                            <input type="password" className="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChangeLogin} />
                                        </div>
                                    </div>
                                </div>

                                <div>
                                    <button type="submit" className="login-button">Login</button>
                                </div>
                                <p>Don't have an account? Sign up <Link to='/register' onClick={(e) => { this.onClose(e); }}>here!</Link></p>
                                <p>Forgot your password? Email us! <br/> beckey@keepingsafetysmart.com</p>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}