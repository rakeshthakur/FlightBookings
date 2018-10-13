import React, { Component } from "react";

import SearchForm from "./SearchForm";
import DisplayFlights from "./DisplayFlights";

export default class Search extends Component {
  constructor() {
    super();
    this.state = {
      searchParameters: {
        source: "",
        destination: "",
        date: "",
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
        <SearchForm />
        <DisplayFlights flights={this.state.flights} />
      </div>
    );
  }
}
