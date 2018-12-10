import { Component } from 'react';

export class Logout extends Component {
    
    handleLogout() {
        fetch('api/account/logout', { method: 'POST' })
            .then(res => {
                window.location.href = '/login';
            });
    }

    render() {
        return (
            this.handleLogout()
        )
    }
}