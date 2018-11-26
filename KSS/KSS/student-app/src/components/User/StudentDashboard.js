﻿import React, { Component } from 'react';
import { Login } from './Login';
import './users.css';

export class StudentDashboard extends Component {
    displayName = StudentDashboard.name

    constructor(props) {
        super(props);
        this.state = {
            enrollments: []
        };
    }

    componentDidMount() {
        fetch('/api/Enrollments/1', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ enrollments: data });
            });
    }

    render() {
        if (!this.props.loginState.loggedIn) {
            return <Login />;
        }
        if (!this.state.enrollments[0]) {
            var noClasses = (
                <p class="kssnotify" >You have not enrolled in any classes.</p>
            );
        }
        return (
            <div>
                <h1>{this.props.loginState.firstName}'s Dashboard</h1>
                <hr id="divider"></hr>
                    { noClasses }
                <div className="studentClasses">
                    <h2 className="title">Your Upcoming Classes:</h2>
                    {this.state.enrollments.map(enrollment =>
                        (
                        <div className="studentClass" key={enrollment.enrollmentId}>
                            <div className="studentClassLeft">
                                {enrollment.instanceStartDateDOW}< br />
                                <span>
                                    {enrollment.instanceStartDateMonthF3} {enrollment.instanceStartDateDay}< br />
                                </span>
                                {enrollment.instanceStartDateTime}
                            </div>
                            <div className="seperator" />
                            <div className="studentClassRight">
                                {enrollment.courseName}<br />
                                {enrollment.locationStreet}, {enrollment.locationCity}, {enrollment.locationState}
                            </div>
                        </div>
                        )
                    )}
                </div>
                <div className="studentClasses">
                    <h2 className="title">Courses Record:</h2>
                    {this.state.enrollments.map(enrollment =>
                        (
                        <div className="studentClass" key={enrollment.enrollmentId}>
                            <div className="studentClassLeft">
                                {enrollment.instanceStartDateDOW}< br />
                                <span>
                                    {enrollment.instanceStartDateMonthF3} {enrollment.instanceStartDateDay}< br />
                                </span>
                                {enrollment.instanceStartDateTime}
                            </div>
                            <div className="seperator" />
                            <div className="studentClassRight">
                                {enrollment.courseName}<br />
                                {enrollment.locationStreet}, {enrollment.locationCity}, {enrollment.locationState}
                            </div>
                        </div>
                        )
                    )}
                </div>
            </div>
        );
    }
}