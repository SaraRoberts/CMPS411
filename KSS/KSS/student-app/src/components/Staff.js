import React, { Component } from 'react';
import { Link } from "react-router-dom";
import { Table, Image } from 'semantic-ui-react';
import './styles/Tables.css';

export class Staff extends Component {
    displayName = Staff.name

    constructor(props) {
        super(props);
        this.state = { staffs: [], loading: true };
    }

    componentDidMount() {
        fetch('/api/Staffs', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ staffs: data, loading: false });
            });
    }

    static renderStaff(staffs) {
        return (
            <Table>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Picture</Table.HeaderCell>
                        <Table.HeaderCell>Bio</Table.HeaderCell>
                        <Table.HeaderCell />
                    </Table.Row>
                </Table.Header>

                <Table.Body>
                    {staffs.map(staffs => (
                        <Table.Row key={staffs.staffBioId}>
                            <Table.Cell><Image src={staffs.picture} max width="300" /></Table.Cell>
                            <Table.Cell>{staffs.bio}</Table.Cell>
                        </Table.Row>
                    ))}
                </Table.Body>
            </Table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Staff.renderStaff(this.state.staffs);

        return (
            <div>
                <div>
                    <h1>Our Staff</h1>
                </div>
                {contents}
            </div>
        );
    }
}