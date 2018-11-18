import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import PaypalExpressBtn from 'react-paypal-express-checkout';
import Modal from 'react-modal';
import { InstanceModal } from './InstanceModal'

const customStyles = {
    content: {
        top: '50%',
        left: '50%',
        right: 'auto',
        bottom: 'auto',
        marginRight: '-50%',
        transform: 'translate(-50%, -50%)'
    }
};

Modal.setAppElement(document.getElementById('root'));


export class CatalogInstances extends Component {
    displayName = CatalogInstances.name

    constructor(props) {
        super(props);
        this.state = {
            instances: [],
            courseInfo: null,
            showR: false,
            modalInstance: {
                id: "",
                price: ""
            }
        };

        console.log(this.props);
        console.log(this.props.match.params.courseId);

        fetch('/api/Instances/GetInstanceByCourseId/' + this.props.match.params.courseId, { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ instances: data, loading: false });
                console.log(data);
            });

        //Pulls course data display course title/description
        fetch('/api/courses/' + this.props.match.params.courseId)
            .then(res => res.json())
            .then(data2 => {
                this.setState({ courseInfo: data2, loading: false });
                console.log(data2);
            });
    }

    showModalR = (passedid, pcourse, plname, plstreet, plcity, plstate, plzip, pstartdate, passedprice) => {
        this.setState({
            ...this.state,
            modalInstance: {
                id: passedid,
                course: pcourse,
                name: plname,
                street: plstreet,
                city: plcity,
                state: plstate,
                zip: plzip, 
                startdate: pstartdate,
                price: passedprice
            },
            showR: !this.state.showR,
        })
    }

    render() {
        return (
            <div id="page">
                <div id="main-container">
                    <div class="grid-container-pages">
                        <div class="grid-item-pages">
                        {this.state && this.state.courseInfo &&
                            <div>
                                <br />
                                <h1>{this.state.courseInfo.name}</h1>
                                <p>{this.state.courseInfo.description}</p>                               
                            </div>
                        } 
                        </div>
                        <div class="grid-item-pages">
                            <Table>
                                <Table.Header>
                                    <Table.Row>
                                        <Table.HeaderCell>Start Date</Table.HeaderCell>
                                        <Table.HeaderCell>Location</Table.HeaderCell>
                                        <Table.HeaderCell>Details</Table.HeaderCell>
                                        <Table.HeaderCell></Table.HeaderCell>
                                    </Table.Row>
                                </Table.Header>
                                <Table.Body>
                                    {this.state.instances.map(instances =>
                                        <Table.Row key={instances.instanceId}>
                                            <Table.Cell>{instances.startDate}</Table.Cell>
                                            <Table.Cell>{instances.locationName}<br />
                                                {instances.locationStreet} <br />
                                                {instances.locationCity}, {instances.locationState} {instances.locationZip}</Table.Cell>
                                            <Table.Cell>Instructor: {instances.instructorName}<br />
                                                Price: ${instances.price}.00<br />
                                                Capacity: {instances.seats}</Table.Cell>
                                            <Table.Cell>
                                                <button
                                                    onClick={
                                                        () => this.showModalR(
                                                            instances.instanceId,
                                                            instances.courseName,
                                                            instances.locationName,
                                                            instances.locationStreet,
                                                            instances.locationCity,
                                                            instances.locationState,
                                                            instances.locationZip,
                                                            instances.startDate,
                                                            instances.price
                                                        )
                                                    }
                                                >Book Now!</button>

                                            </Table.Cell>
                                        </Table.Row>
                                    )}
                                </Table.Body>
                            </Table>
                        </div>
                    </div>

                    <InstanceModal
                        show={this.state.showR}
                        onClose={this.showModalR}
                        modalInstance={this.state.modalInstance}
                    />
                    
                </div>
            </div>
        );
    }
}