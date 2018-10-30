import React, { Component } from 'react';
import ReactDom from 'react-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Table } from 'semantic-ui-react';
import '../styles/Tables.css';

export class MyClasses extends Component {
    displayName = MyClasses.name


    constructor(props) {
        super(props);
        this.state = { instances: [], loading: true };

        fetch('/api/instances', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ instances: data, loading: false });
            });
    }

    static renderinstanceTable(instances) {
        return (

            <Table color={'grey'} inverted inverted>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Course</Table.HeaderCell>
                        <Table.HeaderCell>Start Date</Table.HeaderCell>
                        <Table.HeaderCell>Location</Table.HeaderCell>
                    </Table.Row>
                </Table.Header>

                <Table.Body>
                    {instances.map(instances =>
                        <Table.Row key={instances.instanceId}>
                            <Table.Cell>{instances.courseName}</Table.Cell>
                            <Table.Cell>{instances.startDate}</Table.Cell>
                            <Table.Cell>
                                {instances.locationName}<br/>
                                {instances.locationStreet}<br/>
                                {instances.locationCity}<br/>
                                {instances.locationState}, 
                                {instances.locationZip}<br/>

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
            : MyClasses.renderinstanceTable(this.state.instances);

        return (
            <div id="page">
                <div id="main-container">
                    <div class="grid-container-pages">
                        <div class="grid-item-pages">
                            <h1>Upcoming Classes</h1>
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