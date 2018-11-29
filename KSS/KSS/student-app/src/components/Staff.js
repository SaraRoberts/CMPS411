import React, { Component } from 'react';
import { Link } from "react-router-dom";
import { Table, Image } from 'semantic-ui-react';
import './styles/Tables.css';

export class Staff extends Component {
    displayName = Staff.name

    constructor(props) {
        super(props);
        this.state = { staffs: [], loading: true, featuredStaffId: Math.floor(Math.random() * 10) };
    }

    componentDidMount() {
        fetch('/api/Staffs', { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ staffs: data, loading: false });
            });
    }

    static renderStaff(staffs, featuredStaffId) {
        return (
            <div class="staffBox">
                <div class="staffBoxItem">
                    <Image src={staffs[featuredStaffId].picture} max width="150" />
                </div>
                <div class="staffBoxItem">
                    <p>{staffs[featuredStaffId].bio}</p>
                </div>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Staff.renderStaff(this.state.staffs, this.state.featuredStaffId );

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