import axios from 'axios';
import React, { Component } from 'react';
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
        event.preventDefault();
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
                window.location.href = '/login'; // Redirect to the login page
            })
            .catch(error => (alert("Incorrect registration please try again")))       
    }

    // Visuals
    render() {
        return (
            <div>
                <h2>Sign Up</h2>
                <div className="main-login main-center">
                    <form onSubmit={this.handleSubmit}>
                        <div>
                            <label>Email</label>
                            <div>
                                <input type="text" className="form-blank" name="email" id="email" placeholder="Enter your Email" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <label>Password</label>
                            <div>
                                <input type="password" className="form-blank" name="password" id="password" placeholder="Enter your Password" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <label>Confirm Password</label>
                            <div>
                                <input type="password" className="form-blank" name="confirmPassword" id="confirmPassword" placeholder="Confirm your Password" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <label>First Name</label>
                            <div>
                                <input type="text" className="form-blank" name="firstName" id="firstName" placeholder="Enter your First Name" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <label>Last Name</label>
                            <div>
                                <input type="text" className="form-blank" name="lastName" id="lastName" placeholder="Enter your Last Name" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <label>Phone</label>
                            <div>
                                <input type="text" className="form-blank" name="phone" id="phone" placeholder="(###) ### - ####" onChange={this.handleChange} />
                            </div>
                        </div>
                        <div>
                            <button type="submit" className="login-button">Sign Up</button>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}