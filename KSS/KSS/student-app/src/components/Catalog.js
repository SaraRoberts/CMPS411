import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import { Button, Table } from 'semantic-ui-react';
import './styles/Tables.css';
import PaypalExpressBtn from 'react-paypal-express-checkout';


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
                    <Table.HeaderCell>Category</Table.HeaderCell>
                    <Table.HeaderCell>Course</Table.HeaderCell>
                    <Table.HeaderCell>Description</Table.HeaderCell>
                    <Table.HeaderCell></Table.HeaderCell>
                </Table.Row>
            </Table.Header>

            <Table.Body>
            {courses.map(courses =>
                <Table.Row key={courses.courseId}>
                    <Table.Cell>{courses.categoryName}</Table.Cell>
                    <Table.Cell>{courses.name}</Table.Cell>
                    <Table.Cell>{courses.description}</Table.Cell>
                            <Table.Cell><Button className="details-button" >See Details</Button></Table.Cell>
                            <Table.Cell>
                                <PaypalExpressBtn
                                    env={'sandbox'} //change this to 'production' to complete REAL transactions
                                    client={client}
                                    currency={'USD'}

                                    total={0.05} //change this to adjust price

                                    //output handlers
                                    onSuccess={onSuccess}
                                    onError={onError}
                                    onCancel={onCancel}
                                />
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