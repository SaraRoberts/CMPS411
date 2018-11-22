import React, { Component } from 'react';
import { Login } from './Login';
import { Button, Table } from 'semantic-ui-react';
import './users.css';

export class StudentDashboard extends Component {
    displayName = StudentDashboard.name

    constructor(props) {
        super(props);
        this.state = {
            enrollments: []
        };
    }

    componentWillMount() {
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
        return (
            <div id="main-container">
                <h1>Student Dashboard</h1>
                <h3>Welcome {this.props.loginState.firstName}</h3>
                <div className="studentClasses">
                    <h5>Your Upcoming Classes</h5>
                    {this.state.enrollments.map(enrollment =>
                        <div className="studentClass" key={enrollment.enrollmentId}>
                            <div className="studentClassLeft">
                                {enrollment.instanceStartDateDOW}< br />
                                <span>
                                    {enrollment.instanceStartDateMonthF3} {enrollment.instanceStartDateDay}< br />
                                </span>
                                {enrollment.instanceStartDateTime}
                            </div>
                            <div className="seperator"></div>
                            <div className="studentClassRight">
                                {enrollment.courseName}<br />
                                {enrollment.locationStreet}, {enrollment.locationCity}, {enrollment.locationState}
                            </div>
                        </div>
                    )}
                </div>
                <div className="studentClasses">
                    <h5>Course Records</h5>
                    {this.state.enrollments.map(enrollment =>
                        <div className="studentClass" key={enrollment.enrollmentId}>
                            <div className="studentClassLeft">
                                {enrollment.instanceStartDateDOW}< br />
                                <span>
                                    {enrollment.instanceStartDateMonthF3} {enrollment.instanceStartDateDay}< br />
                                </span>
                                {enrollment.instanceStartDateTime}
                            </div>
                            <div className="seperator"></div>
                            <div className="studentClassRight">
                                {enrollment.courseName}<br />
                                {enrollment.locationStreet}, {enrollment.locationCity}, {enrollment.locationState}
                            </div>
                        </div>
                    )}
                </div>
            </div>
        );
    }
}