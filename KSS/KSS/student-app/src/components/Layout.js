import React, { Component } from 'react';
import { Grid, Row } from 'react-bootstrap';
import { Footer } from './Footer';
import { NavMenu } from './NavMenu';
import './styles/Layout.css';
import { BrandBanner } from './BrandBanner';

export class Layout extends Component {
    displayName = Layout.name

    render() {
        return (
            <Grid fluid>
                <Row>
                    <NavMenu loginState={this.props.loginState}/>
                </Row>
                <Row>
                    <div className="main-container">
                        {this.props.children}
                    </div>
                </Row>
                <Row>
                    <Footer />
                </Row>
            </Grid>
        );
    }
}