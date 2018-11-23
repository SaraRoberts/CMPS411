import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";  
import axios from 'axios';
import './users.css';  

export class Login extends Component {
    displayName = Login.name
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
                    window.location.href = '/dashboard';
                } else {
                    alert('Login failed!!!!');
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
        return (
            <div>
                <h2>Login</h2>
                <div className="main-login main-center">
                    <form onSubmit={this.handleSubmit} method="post">
                        <div>
                            <label>Email</label>
                            <div>
                                <div>
                                    <input type="text" className="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChange} />
                                </div>
                            </div>
                        </div>

                        <div>
                            <label>Password</label>
                            <div>
                                <input type="password" className="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <button type="submit" className="login-button">Login</button>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}