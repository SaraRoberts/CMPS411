import React, { Component } from 'react';
import { Login } from './Login';
import { Button, Table } from 'semantic-ui-react';
import '../styles/Tables.css';

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
                Welcome {this.props.loginState.firstName}
                <div class="grid-container-pages">
                    <div class="grid-item-pages">
                        <Table>
                            <Table.Header>
                                <Table.Row>
                                    <Table.HeaderCell>Your Upcoming Classes</Table.HeaderCell>
                                </Table.Row>
                            </Table.Header>
                            <Table.Body>
                                {this.state.enrollments.map(enrollment =>
                                    <Table.Row key={enrollment.enrollmentId}>
                                        <Table.Cell>
                                            {enrollment.courseName}<br />
                                            {enrollment.instanceStartDate}
                                        </Table.Cell>
                                        <Table.Cell>{enrollment.locationName}<br />
                                            {enrollment.locationCity}, {enrollment.locationState}
                                        </Table.Cell>
                                        <Table.Cell>
                                            Instructor: {enrollment.instructorName} <br />
                                            Price: ${enrollment.price}.00
                                        </Table.Cell>
                                    </Table.Row>
                                )}
                            </Table.Body>
                        </Table>
                    </div>
                </div>
            </div>
        );
    }
}