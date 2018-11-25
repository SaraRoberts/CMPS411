import React, { Component } from 'react';
import { Route } from "react-router-dom";
import './App.css';
import { Catalog } from './components/Catalog';
import { CatalogInstances } from './components/CatalogInstances';
import { Account } from './components/Dashboard/Account';
import { Group } from './components/Group';
import { Home } from './components/Home';
import { Layout } from './components/Layout';
import { Login } from './components/User/Login';
import { Logout } from './components/User/Logout';
import { Register } from './components/User/Register';
import { StudentDashboard } from './components/User/StudentDashboard';

class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            loginState: {
                loggedIn: false,
                userId: null,
                firstName: ""
            }
        };
    }

    componentDidMount() {
        fetch('/api/users', { credentials: 'same-origin' })
            .then(response => {
                if (response.ok) {
                    this.setState({
                        loginState: {
                            loggedIn: true,
                            userId: null,
                            firstName: ""
                        }
                    });
                    if (this.state.loginState.loggedIn) {
                        fetch('/api/users', { credentials: 'same-origin' })
                            .then(response => response.json())
                            .then(data => {
                                this.setState({
                                    loginState: {
                                        loggedIn: true,
                                        userId: data.userId,
                                        firstName: data.firstName
                                    }
                                });
                            });
                    }
                }
            });
    }

    render() {
        return (
            <Layout loginState={this.state.loginState}>
                <Route exact path='/' render={(props) => <Home {...props} loginState={this.state.loginState} />} />
                <Route exact path='/catalog' render={(props) => <Catalog {...props} loginState={this.state.loginState} />} />
                <Route path='/catalog/:courseId' render={(props) => <CatalogInstances {...props} loginState={this.state.loginState} />} />
                <Route path='/group' render={(props) => <Group {...props} loginState={this.state.loginState} />} />
                <Route path='/account' render={(props) => <Account {...props} loginState={this.state.loginState} />} />
                <Route path='/login' render={(props) => <Login {...props} loginState={this.state.loginState} />} />
                <Route path='/logout' render={(props) => <Logout {...props} loginState={this.state.loginState} />} />
                <Route path='/register' render={(props) => <Register {...props} loginState={this.state.loginState} />} />
                <Route path='/dashboard' render={(props) => <StudentDashboard {...props} loginState={this.state.loginState} />} />
            </Layout>
        );
    }
}

export default App;
