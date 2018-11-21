import React, { Component } from 'react';
import { Login } from './Login';

export class StudentDashboard extends Component {
    displayName = StudentDashboard.name


    render() {
        if (!this.props.loginState.loggedIn) {
            return <Login />;
        }
        return (
                <div id="main-container">
                <h1>Student Dashboard</h1>
                Welcome {this.props.loginState.firstName}
                    <h2>My Upcoming Classes</h2>
                </div>
        );
    }
}