import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import './App.css';

class App extends Component {
    render() {
        return (
            <div className="App">
                <Layout>
                    <BrowserRouter>
                        <Switch>
                            <Route exact path='/' component={Home} />
                        </Switch>
                    </BrowserRouter>
                </Layout>
            </div>
        );
    }
}

export default App;
