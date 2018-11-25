import React, { Component } from 'react';
import groupPage from './images/groupPage.jpg';
import { InstanceModal } from './InstanceModal';
import './styles/CatalogInstances.css';
import './styles/Tables.css';




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
        if (!this.state.instances[0]) {
            var noClasses = (
                <p>Sorry, no classes are currently scheduled.</p>
            );
        }
        var disabled = false;
        var hideButton = false;
        if (!this.props.loginState.loggedIn) {
            disabled = true
            hideButton = true;
        }

        return (
            <div>
                <img id="headerImage" src={groupPage} alt="Groups1" />
                <div className="tworow" id="catalogInstance">
                    <div className="twocolumn">
                        <div className="courseClasses">
                            <h5>Upcoming Classes</h5>
                            <h5 hidden={!hideButton}>please log in to book a class</h5>
                            { noClasses }
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
                                                    () => this.showModal(instance)
                                                }
                                                disabled={disabled}
                                                hidden={hideButton}
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