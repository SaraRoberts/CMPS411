import React, { Component } from 'react';
import axios from 'axios';
import './styles/InstanceModal.css';
import './User/users.css';  

export class LoginModal extends Component {
    //Follows pattern (pretty much the same thing) as the register page
    //Constructor
    constructor(props) {
        super(props);
        this.state = {
            credentials: {
                email: "",
                password: ""
            }
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }

    //Handles Change
    handleChange = e => {
        var credentials = {
            ...this.state.credentials,
            [e.target.name]: e.target.value
        };
        this.setState({ credentials: credentials });
    }

    //Handles Submit
    handleSubmit = e => {

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
                    //this.login()
                } else {
                    alert('Login failed!!!!');
                    //this.setState({
                    //    loginError: "Invalid credentials, try again!"
                    //})
                }
            });

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
                    <div class="container">
                        <div class="row main">
                            <div class="panel-heading">
                                <h2>Login</h2>
                            </div>
                            <div class="main-login main-center">
                                <form onSubmit={this.handleSubmit} class="form-horizontal" method="post">
                                    <div class="form-group">
                                        <label for="email" class="cols-sm-2 control-label">Email</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="password" class="cols-sm-2 control-label">Password</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                                <input type="password" class="form-control" class="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group ">
                                        <button type="submit" class="btn btn-primary btn-lg btn-block login-button">Login</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>


                <div id="sign-up" onClick="">
                    <span id="closeButton" onClick={(e) => { this.onClose(e) }} onMouseOver="">
                        Close[X]
                    </span>
                    <h2>Sign up</h2>
                    <div class="container">
                        <div class="row main">
                            <div class="main-login main-center" >
                                <form onSubmit={this.handleSubmit} class="form-horizontal">

                                    <div class="form-group">
                                        <label for="email" class="cols-sm-2 control-label">Email</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="password" class="cols-sm-2 control-label">Password</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                                <input type="password" class="form-control" class="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="confirmPassword" class="cols-sm-2 control-label">Confirm Password</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                                <input type="password" class="form-control" class="form-blank" name="confirmPassword" id="confirmPassword" placeholder="Confirm your Password" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="addressLine1" class="cols-sm-2 control-label">First Name</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="firstName" id="firstName" placeholder="Enter your First Name" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="addressLine1" class="cols-sm-2 control-label">Last Name</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="lastName" id="lastName" placeholder="Enter your Last Name" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="addressLine2" class="cols-sm-2 control-label">Phone</label>
                                        <div class="cols-sm-10">
                                            <div class="input-group">
                                                <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                                <input type="text" class="form-control" class="form-blank" name="phone" id="phone" placeholder="(###) ### - ####" onChange={this.handleChange} />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group ">
                                        <button type="submit" class="btn btn-primary btn-lg btn-block login-button">Sign Up</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}