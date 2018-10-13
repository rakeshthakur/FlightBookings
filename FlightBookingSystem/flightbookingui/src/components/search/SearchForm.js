import React from "react";

export default class SearchForm extends React.Component {
  constructor() {
    super();
    this.onClick = this.onClick.bind(this);

    this.state = {
      source: "",
      destination: "",
      date: new Date().getDate().toDateString(),
      travelClass: ""
    };
  }

  onClick() {
    //TODO: Add code to invoke the Flight service here to get matching flights
  }

  componentDidMount() {
    let { flight } = this.props;
    this.setState({ ...this.state, flight });
  }

  render() {
    return (
      <div>
        <label htmlFor="source">Flying from</label>
        <text name="search" value={this.state.source} />
        <label htmlFor="destination">Flying to</label>
        <text name="destination" value={this.state.sea} />
        <label htmlFor="destination">Flying from</label>
        <input type="date" name="date" />

        <button type="button" onClick={this.onClick}>
          Search
        </button>
      </div>
    );
  }
}
