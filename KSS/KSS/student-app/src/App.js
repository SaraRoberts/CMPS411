import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
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
import './App.css';

class App extends Component {
    render() {
        return (
            <div className="App">
                <Layout>
                    <BrowserRouter>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route path='/catalog' component={Catalog} />
                            <Route path='/cataloginstances' component={CatalogInstances} />
                            <Route path='/contact' component={Contact} />
                            <Route path='/group' component={Group} />
                            <Route path='/account' component={Account} />
                            <Route path='/myclasses' component={MyClasses} />
                            <Route path='/search' component={Search} />
                            <Route path='/login' component={Login} />
                            <Route path='/logout' component={Logout} />
                            <Route path='/payment' component={Payment} />
                            <Route exact path='/register' component={Register} />
                        </Switch>
                    </BrowserRouter>
                </Layout>
            </div>
        );
    }
}

export default App;
