import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import PaypalExpressBtn from 'react-paypal-express-checkout';
import Modal from 'react-modal';
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
        this.state = { instances: [], loading: true, courseInfo: null, modalIsOpen: false   };

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
        this.openModal = this.openModal.bind(this);
        this.afterOpenModal = this.afterOpenModal.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    openModal() {
        this.setState({ modalIsOpen: true });
    }

    afterOpenModal() {
        // references are now sync'd and can be accessed.
        this.subtitle.style.color = '#f00';
    }

    closeModal() {
        this.setState({ modalIsOpen: false });
    }

    static rendercourseTable(instances) {
        const onSuccess = (payment) => {
            console.log("Successful: ", payment);
        };

        //Output in browser console on cancel (closing the window)
        const onCancel = (data) => {
            console.log('Canceled', data);
        };

        //If an error is encountered in the API or it crashes
        const onError = (err) => {
            console.log("Failure: ", err);
        };

        const client = {
            //For testing, use sandbox, for live, use Production. The 'env' variable will also need to be changed in the PayPalExpressBtn element below
            sandbox: 'AU7-TZCTcPacLNP7bj74quFlQPLWzG9jlMB8Zqr5m4wnygK-ckrcuV6izspeNmb-su0VXrXWSsjXZAY-',
            production: 'ATt_35Hio2zgeOr0HRxARGxst3ewohkZXzSJ7N4Ds3kwynkon66oriV6zuxLq5RfYW5l64d0dQJoBTAB'
        };

        return (
            <Table>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Start Date</Table.HeaderCell>
                        <Table.HeaderCell>Location</Table.HeaderCell>
                        <Table.HeaderCell>Details</Table.HeaderCell>
                        <Table.HeaderCell></Table.HeaderCell>
                        <Table.HeaderCell></Table.HeaderCell>
                    </Table.Row>
                </Table.Header>
                <Table.Body>
                    {instances.map(instances =>
                        <Table.Row key={instances.instanceId}>
                            <Table.Cell>{instances.startDate}</Table.Cell>
                            <Table.Cell>{instances.locationName}<br />
                                        {instances.locationStreet} <br />
                                        {instances.locationCity}, {instances.locationState} {instances.locationZip}</Table.Cell>
                            <Table.Cell>Instructor: {instances.instructorName}<br />
                                        Price: ${instances.price}.00<br />
                                        Capacity: {instances.seats}</Table.Cell>
                            <Table.Cell>
                                <Button className="details-button" >See Details</Button>
                                <PaypalExpressBtn
                                    env={'sandbox'} //change this to 'production' to complete REAL transactions
                                    client={client}
                                    currency={'USD'}

                                    total={instances.price} //change this to adjust price

                                    //output handlers
                                    onSuccess={onSuccess}
                                    onError={onError}
                                    onCancel={onCancel}
                                />
                            </Table.Cell>
                            <Table.Cell>
                               
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
            : CatalogInstances.rendercourseTable(this.state.instances);

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
                            {contents}
                        </div>
                    </div>
                    <button onClick={this.openModal}>Open Modal</button>
                    <Modal
                        isOpen={this.state.modalIsOpen}
                        onAfterOpen={this.afterOpenModal}
                        onRequestClose={this.closeModal}
                        style={customStyles}
                        contentLabel="Example Modal"
                    >

                        <h2 ref={subtitle => this.subtitle = subtitle}>Hello</h2>
                        <button onClick={this.closeModal}>close</button>
                        <div>I am a modal</div>
                        <form>
                            <input />
                            <button>tab navigation</button>
                            <button>stays</button>
                            <button>inside</button>
                            <button>the modal</button>
                        </form>
                    </Modal>
                </div>
            </div>
        );
    }
}