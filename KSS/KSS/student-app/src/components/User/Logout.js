import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { withRouter } from 'react-router-dom';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export class Logout extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            email: '',
            password: '',
            user: ''
        };
        this.handleLogout = this.handleLogout.bind(this);
    }

    handleLogout() {
        axios.get('api/account/logout')
        .then(response => alert("Logged out"));
        this.handleHome();
    }

    handleHome() {
        console.log(this.props)
        //this.props.history.push('/login')
        window.location.href = '/login/'
    }
    render() {
        //console.log("render");
        //console.log(this.props.user);
        if (this.props.user == 0) {
            return (
                <div>You are not logged in</div>
    )
}
else {
    return (
        this.handleLogout()
        //<div>
        //    <button onClick={this.handleLogout}> Logout </button>
        //</div>
    )
}
}
}
export default Logout;