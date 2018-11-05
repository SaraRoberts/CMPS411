import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import axios from 'axios';
import './users.css';  

export class Register extends Component {
    displayName = Register.name

    //Constructor
    constructor(props) {
        super(props);
        this.state = {
            email: "",
            password: "",
            confirmPassword: "",
            firstName: "",
            lastName: "",
            phone: ""
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
            confirmPassword: this.state.confirmPassword,
            firstName: this.state.firstName,
            lastName: this.state.lastName,
            phone: this.state.phone
        };

    // Posts to the API
        axios.post('api/account/register', user)
            .then(res => {
                console.log(res);
                console.log(res.data);
            })
            .catch(error => (alert("Incorrect registration please try again")))

        alert("Thank you for registering!")
    }

    // Visuals
    render() {
        return (
            <div class="container">
                <div class="row main">
                    <div class="panel-heading">
                        <div class="panel-title text-center">
                            <h3 class="title">Sign Up </h3>
                            <hr />
                        </div>
                    </div>
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
        );
    }
}