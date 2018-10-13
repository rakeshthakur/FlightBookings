import React, { Component } from "react";

import SearchForm from "./SearchForm";
import DisplayFlights from "./DisplayFlights";

export default class Search extends Component {
  constructor() {
    super();
    this.state = {
      searchParameters: {
        source: "Chennai",
        destination: "New Delhi",
        date: new Date().toLocaleDateString(),
        travelClass: ""
      },
      flights: []
    };
  }

  componentDidMount() {
    //TODO:Add code to retrieve flights
  }
  render() {
    return (
      <div className="searchbox">
        <SearchForm params={this.state.searchParameters} />
        <DisplayFlights flights={this.state.flights} />
      </div>
    );
  }
}
