import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './styles/InstanceModal.css';
import './User/users.css';

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
        fetch('api/account/login', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            credentials: 'same-origin',
            body: JSON.stringify(this.state.credentials)
        })
            .then(response => {
                if (response.ok) {
                    alert('Login successful, ok to continue.');
                    window.location.href = '/account';
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
        if (!this.props.show) return null
        return (
            <div id="modalBack">
                <div id="login">
                    <span id="closeButton" onClick={(e) => { this.onClose(e) }} onMouseOver="">
                        X &nbsp;
                    </span>
                    <div class="container">
                        <div class="row main">
                            <div class="panel-heading">
                                <h1 id="header">Login</h1>
                            </div>
                            <hr id="divider"></hr>
                            <div class="main-login main-center">
                                <form onSubmit={this.handleSubmitLogin} method="post">
                                    <div>
                                        <label for="email">Email</label>
                                        <div>
                                            <div>
                                                <span><i aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChangeLogin} />
                                            </div>
                                        </div>
                                    </div>
                                    <div>
                                        <label>Password</label>
                                        <div>
                                            <div>
                                                <span><i aria-hidden="true"></i></span>
                                                <input type="password" class="form-control" class="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChangeLogin} />
                                            </div>
                                        </div>
                                    </div>

                                    <div>
                                        <button type="submit" className="login-button">Login</button>
                                    </div>
                                    <p>Don't have an account? Sign up <Link to='/register' onClick={(e) => { this.onClose(e) }}>here!</Link></p>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}