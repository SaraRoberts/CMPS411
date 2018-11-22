import React, { Component } from 'react';
import { Grid, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { Footer } from './Footer';

export class Layout extends Component {
    displayName = Layout.name

    render() {
        console.log(this.props);

        return (
            <Grid fluid>
                <Row>
                    <NavMenu loginState={this.props.loginState}/>
                </Row>
                <Row>
                    {this.props.children}
                </Row>
                <Row>
                    <Footer />
                </Row>
            </Grid>
        );
    }
}