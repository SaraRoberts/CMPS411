import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import Modal from 'react-modal';
import './styles/InstanceModal.css';
import './User/users.css';
import { Button } from 'semantic-ui-react';

export class FullWarning extends Component {
    //Moethod to close modal
    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }

    //render elements on page
    render() {
        if (!this.props.show) return null
        return (
            <div id="modalBack">
                <div id="full-warning">
                    <p>This class is full</p>
                    <Button id="closeFullWarningModal"
                        onClick={
                            (e) => {
                                this.onClose(e)
                            }
                        }//end onClick
                        onMouseOver = ""
                    >Okay</Button>
                </div>
            </div>
        );
    }
}