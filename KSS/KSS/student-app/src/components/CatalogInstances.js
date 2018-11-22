import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import Modal from 'react-modal';
import { InstanceModal } from './InstanceModal';
import EMTImage from './images/EMTImage.jpeg';
import './styles/CatalogInstances.css';
import groupPage from './images/groupPage.jpg';

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
            <div id="main-container">
                <img id="headerImage" src={groupPage} alt="Groups1" />
                <div className="tworow">
                    <div className="twocolumn">
                        <div className="studentClasses">
                            <h5>Upcoming Classes</h5>
                            {this.state.instances.map(instance =>
                                (
                                    <div className="studentClass" key={instance.enrollmentId}>
                                        <div className="studentClassLeft">
                                            {instance.startDateDOW}< br />
                                            <span>
                                                {instance.startDateMonthF3} {instance.startDateDay}< br />
                                            </span>
                                            {instance.startDateTime}
                                        </div>
                                        <div className="seperator" />
                                        <div className="studentClassMiddle">
                                            Price: ${instance.price}.00<br />
                                            Open Seats: {instance.seats}<br />
                                            {instance.locationName}<br />
                                            {instance.instructorName}
                                        </div>
                                        <div className="studentClassRight">
                                            <button
                                                className="redButton"
                                                onClick={
                                                    () => this.showModal(instance)}>Book!
                                            </button>
                                        </div>
                                    </div>
                                )
                            )}
                        </div>
                    </div>
                    {this.state && this.state.courseInfo &&
                        <div className="twocolumn" id="info">
                            <h2>{this.state.courseInfo.name}</h2>
                            <p>{this.state.courseInfo.description}</p>
                        </div>
                    }
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