import React, { Component } from 'react';
import './styles/InstanceModal.css';

export class LoginModal extends Component {
    constructor(props) {
        super(props);
    }

    onClose = (e) => {
        this.props.onClose && this.props.onClose(e)
    }

    render() {
        if (!this.props.show) return null

        return (
            <div id="modalBack">
                    <div id="modal-left"></div>
                    <div id="modal-right" onClick="">
                        <span id="closeButton" onClick={(e) => { this.onClose(e) }} onMouseOver="">
                            X
                            </span>
                    <h5>or <a href="/">Book and Pay Later</a></h5>
                </div>
            </div>
        );
    }
}