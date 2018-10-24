import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import './users.css';  

export class Register extends Component {
    displayName = Register.name


    render() {
        return (
            <div class="container">
                <div class="row main">
                    <div class="panel-heading">
                        <div class="panel-title text-center">
                            <h3 class="title">Register </h3>
                            <hr />
                        </div>
                    </div>
                    <div class="main-login main-center">
                        <form onSubmit={this.handleSubmit} class="form-horizontal">

                            <div class="form-group">
                                <label for="email" class="cols-sm-2 control-label">Email</label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                        <input type="text" class="form-control" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="password" class="cols-sm-2 control-label">Password</label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                        <input type="password" class="form-control" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="confirmPassword" class="cols-sm-2 control-label">Confirm Password</label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                        <input type="password" class="form-control" name="confirmPassword" id="confirmPassword" placeholder="Confirm your Password" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="addressLine1" class="cols-sm-2 control-label">First Name</label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                        <input type="text" class="form-control" name="firstName" id="firstName" placeholder="Enter your First Name" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="addressLine1" class="cols-sm-2 control-label">Last Name</label>
                                    <div class="cols-sm-10">
                                        <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                        <input type="text" class="form-control" name="lastName" id="lastName" placeholder="Enter your Last Name" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="addressLine2" class="cols-sm-2 control-label">Phone</label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                        <input type="text" class="form-control" name="phone" id="phone" placeholder="(###) ### - ####" onChange={this.handleChange} />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group ">
                                <button type="submit" class="btn btn-primary btn-lg btn-block login-button">Register</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        );
    }
}