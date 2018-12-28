import React, { Component } from 'react';
import { Login } from './Login';
import './users.css';

export class StudentDashboard extends Component {
    displayName = StudentDashboard.name

    constructor(props) {
        super(props);
        this.state = {
            enrollments: [],
            coursesTaken: []
        };
    }

    componentDidMount() {
        fetch('/api/Enrollments/1', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ enrollments: data });
            });
        fetch('/api/Enrollments/2', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ coursesTaken: data });
            });
    }

    render() {
        if (!this.props.loginState.loggedIn) {
            return <Login />;
        }
        if (!this.state.enrollments[0]) {
            var noClasses = <p className="kssnotify" >You have not enrolled in any classes.</p>;
        }
        if (!this.state.coursesTaken[0]) {
            var noneTaken = <p className="kssnotify" >You have not taken any classes.</p>;
        }
        return (
            <div id="studentDashboard">
                <br/>
                <h1>{this.props.loginState.firstName}'s Dashboard</h1>
                <hr id="divider" />
                <br />
                <div className="studentClasses">
                    <h2>Your Upcoming Classes</h2>
                    {noClasses}
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
                    <h2>Courses Taken</h2>
                    {noneTaken}
                    {this.state.coursesTaken.map(courseTaken =>
                        (
                        <div className="studentClass" key={courseTaken.enrollmentId}>
                            <div className="studentClassLeft">
                                {courseTaken.instanceStartDateDOW}< br />
                                <span>
                                    {courseTaken.instanceStartDateMonthF3} {courseTaken.instanceStartDateDay}< br />
                                </span>
                                {courseTaken.instanceStartDateTime}
                            </div>
                            <div className="seperator" />
                            <div className="studentClassRight">
                                {courseTaken.courseName}<br />
                                {courseTaken.locationStreet}, {courseTaken.locationCity}, {courseTaken.locationState}
                            </div>
                        </div>
                        )
                    )}
                </div>
            </div>
        );
    }
}