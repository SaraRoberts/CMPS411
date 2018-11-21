import React, { Component } from 'react';

export class Logout extends React.Component {
    
    handleLogout() {
        fetch('api/account/logout', { method: 'POST' });
        window.location.href = '/login';
    }

    render() {
        return (
            this.handleLogout()
        )
    }
}