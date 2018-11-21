import React, { Component } from 'react';
import { BrowserRouter, Route } from "react-router-dom";
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Catalog } from './components/Catalog';
import { CatalogInstances } from './components/CatalogInstances';
import { Contact } from './components/Contact';
import { Group } from './components/Group';
import { Account } from './components/Dashboard/Account';
import { MyClasses } from './components/Dashboard/MyClasses';
import { Search } from './components/Dashboard/Search';
import { Login } from './components/User/Login';
import { Logout } from './components/User/Logout';
import { Register } from './components/User/Register';
import { Payment } from './components/Payment';
import { StudentDashboard } from './components/User/StudentDashboard';
import './App.css';

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
        fetch('/api/users', { credentials: 'same-origin' })
            .then(response => {
                if (response.ok) {
                    this.setState({
                        loginState: {
                            loggedIn: true,
                            userId: null,
                            firstName: "test2"
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
            <div className="App">
                <Layout loginState={this.state.loginState}>
                            <Route exact path='/' component={() => <Home loginState={this.state.loginState} />} />
                            <Route exact path='/catalog' component={Catalog} />
                            <Route path='/catalog/:courseId' component={CatalogInstances} />
                            <Route path='/contact' component={Contact} />
                            <Route path='/group' component={Group} />
                            <Route path='/account' component={Account} />
                            <Route path='/myclasses' component={MyClasses} />
                            <Route path='/search' component={Search} />
                            <Route path='/login' component={() => <Login loginState={this.state.loginState} />}/>
                            <Route path='/logout' component={Logout} />
                            <Route path='/payment' component={Payment} />
                            <Route exact path='/register' component={Register} />
                            <Route path='/dashboard' component={() => <StudentDashboard loginState={this.state.loginState} />} />
                </Layout>
            </div>
        );
    }
}

export default App;
