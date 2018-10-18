import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { Footer } from './Footer';

export class Layout extends Component {
    displayName = Layout.name

    render() {
        var style = { minHeight: '600px' };
        console.log(this.props)

        return (
            <Grid fluid>
                <Row>
                    <Col>
                        <NavMenu />
                    </Col>
                </Row>

                <Row>
                    <Col style={style}>
                        {this.props.children}
                    </Col>
                </Row>

                <Row>
                    <Col>
                        <Footer />
                    </Col>
                </Row>

            </Grid>
        );
    }
}