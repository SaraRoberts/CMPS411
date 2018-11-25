﻿import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import Modal from 'react-modal';
import { InstanceModal } from './InstanceModal';
import EMTImage from './images/EMTImage.jpeg';
import './styles/CatalogInstances.css';
import groupPage from './images/groupPage.jpg';




export class CatalogInstances extends Component {
    displayName = CatalogInstances.name

    constructor(props) {
        super(props);
        this.state = {
            instances: [],
            showM: false,
            modalInstance: null
        };
    }

    componentDidMount() {
        fetch('/api/Instances/GetInstanceByCourseId/' + this.props.match.params.courseId, { credentials: 'same-origin' })
            .then(response => response.json())
            .then(data => {
                this.setState({ instances: data, loading: false });
                console.log(data);
            });
    }

    showModal = (instance) => {
        if (!this.state.show) {
            this.setState({
                ...this.state,
                modalInstance: instance,
                show: !this.state.show,
            });
        }
        else {
            this.setState({
                ...this.state,
                show: !this.state.show,
            });
        }
    }

    render() {
        return (
            <div>
                <img id="headerImage" src={groupPage} alt="Groups1" />
                <div className="tworow">
                    <div className="twocolumn">
                        <div className="courseClasses">
                            <h5>Upcoming Classes</h5>
                            {this.state.instances.map(instance =>
                                (
                                <div className="courseClass" key={instance.enrollmentId}>
                                    <div className="courseClassLeft">
                                        {instance.startDateDOW}< br />
                                        <span>
                                            {instance.startDateMonthF3} {instance.startDateDay}< br />
                                        </span>
                                        {instance.startDateTime}
                                    </div>
                                    <div className="seperator" />
                                    <div className="courseClassMiddle">
                                        Price: ${instance.price}.00<br />
                                        Open Seats: {instance.seatsAvailable}<br />
                                        {instance.locationName}<br />
                                        {instance.instructorName}
                                    </div>
                                    <div className="courseClassRight">
                                        <button
                                            className="redButton"
                                            onClick={
                                                () => this.showModal(instance)}
                                        >Book!
                                        </button>
                                    </div>
                                </div>
                                )
                            )}
                        </div>
                    </div>
                    <div className="twocolumn" id="info">
                        <h2>{this.props.location.state.courseName}</h2>
                        <p>{this.props.location.state.courseDescription}</p>
                    </div>
                </div>
                    
                <InstanceModal
                    show={this.state.show}
                    onClose={this.showModal}
                    modalInstance={this.state.modalInstance}
                />  
            </div>
        );
    }
}