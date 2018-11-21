import React, { Component } from 'react';

export class StudentDashboard extends Component {
    displayName = StudentDashboard.name


    render() {
        return (
                <div id="main-container">
                    <h1>Student Dashboard</h1>
                    <h2>My Upcoming Classes</h2>
                </div>
        );
    }
}