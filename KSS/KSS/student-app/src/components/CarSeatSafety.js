import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import car from './images/car.jpg';
import initialsLogo from './images/initialsLogo.png';
import './styles/GroupPage.css';

export class CarSeatSafety extends Component {
    displayName = CarSeatSafety.name

    componentDidMount() {
        document.title = "Keeping Safety Smart | Car Seat Safety";
    }

    render() {
        return (
            <div>
            <div id="groupBanner" alt="Group Safety Classes" />

            <div className="groupInfo">
            <div>
            <h2>Car Seat Safety</h2>
            <p>
                We offer assistance with car seat installation and safety free of charge to make sure
                your little ones ride safely. Please contact Nicole Dufrene for more information!
            </p>
            <p>
                Nicole Dufrene, EMR <br />
                nicoledufrene0301@gmail.com<br></br>
            </p>
    </div>
        </div>
                <div className="carInfo">
                    <br /><br /><br /><br /><br />
                <img src={car} alt="Group Safety Classes image" />
            </div>
        </div>
        );
    }
}