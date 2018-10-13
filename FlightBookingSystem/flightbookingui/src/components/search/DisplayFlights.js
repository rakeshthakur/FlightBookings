import React from "react";

export default class DisplayFlights extends React.Component {
  constructor() {
    super();

    this.onBookNowClick = this.onBookNowClick.bind(this);
  }

  onBookNowClick() {
    //TODO: Load the Booking component by passing the parameters like scheduleid(flight no., date etc.)
  }

  render() {
    return (
      <div>
        <table>
          <thead>
            <tr>
              <td>&nbsp;</td>
              <td>Flight No.</td>
              <td>Source</td>
              <td>Destination</td>
              <td>Price</td>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>
                <button type="button" onClick={this.onBookNowClick}>
                  Book Now
                </button>
              </td>
              <td>6E-2908</td>
              <td>New Delhi</td>
              <td>Chennai</td>
              <td>4186</td>
            </tr>
          </tbody>
        </table>
      </div>
    );
  }
}
