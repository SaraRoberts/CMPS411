import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import Modal from 'react-modal';
import { InstanceModal } from './InstanceModal'
import EMTImage from './images/EMTImage.jpeg'

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
            showM: false,
            modalInstance: null
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

    showModal = (instance) => {
        if (!this.state.show) {
            this.setState({
                ...this.state,
                modalInstance: instance,
                show: !this.state.show,
            })
        }
        else {
            this.setState({
                ...this.state,
                show: !this.state.show,
            })
        }
    }

    render() {
        return (
            <div id="page">
                <div id="main-container">
                    <div id="courseHeader">
                        <div><img src={EMTImage} /></div>
                    </div>
                    <div class="grid-container-pages">
                        <div class="grid-item-pages">
                        {this.state && this.state.courseInfo &&
                            <div>
                                <br />
                                <h2>{this.state.courseInfo.name}</h2>
                                <p>{this.state.courseInfo.description}</p>                               
                            </div>
                        } 
                        </div>
                        <div class="grid-item-pages">
                            <Table>
                                <Table.Header>
                                    <Table.Row>
                                        <Table.HeaderCell>Upcoming Classes</Table.HeaderCell>
                                    </Table.Row>
                                </Table.Header>
                                <Table.Body>
                                    {this.state.instances.map(instance =>
                                        <Table.Row key={instance.instanceId}>
                                            <Table.Cell>
                                                {instance.startDate}<br />
                                                {instance.instructorName}
                                            </Table.Cell>
                                            <Table.Cell>{instance.locationName}<br />
                                                {instance.locationCity}, {instance.locationState}
                                            </Table.Cell>
                                            <Table.Cell>
                                                Open Seats: {instance.seats} <br />
                                                Price: ${instance.price}.00
                                            </Table.Cell>
                                            <Table.Cell>
                                                <button
                                                    className="redButton"
                                                    onClick={
                                                        () => this.showModal(instance)}>Book Now!
                                                </button>
                                            </Table.Cell>
                                        </Table.Row>
                                    )}
                                </Table.Body>
                            </Table>
                        </div>
                    </div>

                    <InstanceModal
                        show={this.state.show}
                        onClose={this.showModal}
                        modalInstance={this.state.modalInstance}
                    />
                    
                </div>
            </div>
        );
    }
}