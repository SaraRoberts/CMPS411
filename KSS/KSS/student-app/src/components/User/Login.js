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
            email: "",
            password: ""
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    //Handles Change
    handleChange(event) {
        this.setState({ [event.target.name]: event.target.value });
    }
    //Handles Submit
    handleSubmit(event) {
        const user = {
            email: this.state.email,
            password: this.state.password,
        };

        // Posts to the API
        axios.post('api/account/login', user)
            .then(res => {
                console.log(res);
                console.log(res.data);
            })
            .catch(error => (alert("Incorrect Login, please try again")))

        alert("Wow, the login worked!")
    }

    render() {
        return (
            <div class="container">
                <div class="row main">
                    <div class="panel-heading">
                        <div class="panel-title text-center">
                            <h3 class="title">Login</h3>
                            <hr />
                        </div>
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
        );
    }
}