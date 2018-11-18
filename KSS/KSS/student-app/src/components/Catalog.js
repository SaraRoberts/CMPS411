import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';


export class Catalog extends Component {
    displayName = Catalog.name

    constructor(props) {
        super(props);
        this.state = { courses: [], loading: true };

        fetch('/api/courses', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ courses: data, loading: false });
            });
    }

    static rendercourseTable(courses) {
      return (
        <Table>
            <Table.Header>
                <Table.Row>
                    <Table.HeaderCell>Course</Table.HeaderCell>
                    <Table.HeaderCell>Description</Table.HeaderCell>
                    <Table.HeaderCell></Table.HeaderCell>
                </Table.Row>
            </Table.Header>

            <Table.Body>
            {courses.map(courses =>
                <Table.Row key={courses.courseId}>
                    <Table.Cell>{courses.name}</Table.Cell>
                    <Table.Cell>{courses.description}</Table.Cell>
                    <Table.Cell>
                        <Link to={`catalog/${courses.courseId}`}>
                            <button className="redButton">
                                Upcoming Classes
                            </button>
                        </Link>
                    </Table.Cell>
                </Table.Row>
                )}
            </Table.Body>
        </Table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Catalog.rendercourseTable(this.state.courses);

    return (
        <div id="page">
            <div id="main-container">
                <div class="grid-container-pages">
                    <div class="grid-item-pages">
                        <h1>Course Catalog</h1>
                        <p>
                            Keeping Safety Smart offers a variety of courses that teach valuable first responder skills. Search through
                            course listings below.
                        </p>
                    </div>
                    <div class="grid-item-pages">
                        {contents}
                    </div>
                </div>
            </div>
        </div>
        );
    }
}