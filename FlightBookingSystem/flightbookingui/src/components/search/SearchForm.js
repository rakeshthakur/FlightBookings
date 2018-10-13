import React from "react";

export default class SearchForm extends React.Component {
  constructor() {
    super();

    this.onClick = this.onClick.bind(this);
    this.onSourceChange = this.onSourceChange.bind(this);
    this.onDestinationChange = this.onDestinationChange.bind(this);
    this.onDateChange = this.onDateChange.bind(this);

    this.state = {
      source: "",
      destination: "",
      date: new Date().toLocaleDateString(),
      travelClass: ""
    };
  }

  onClick() {
    //TODO: Add code to invoke the Flight service here to get matching flights
  }

  onSourceChange(event) {
    console.log("Source change event.");
    this.setState({ source: event.target.value });
  }

  onDestinationChange(event) {
    this.setState({ destination: event.target.value });
  }

  onDateChange(event) {
    this.setState({ date: event.target.value });
  }

  componentDidMount() {
    console.log(this.props);
    let params = this.props;
    console.log(params);
    this.setState({ ...params });
  }

  render() {
    return (
      <div>
        <span>
          <label htmlFor="source">Flying from</label>
          <input
            type="text"
            style={{ width: "22px" }}
            name="source"
            value={this.state.source}
            onChange={this.onSourceChange}
          />
        </span>
        <span>
          <label htmlFor="destination">Flying to</label>
          <input
            type="text"
            name="destination"
            value={this.state.destination}
            onChange={this.onDestinationChange}
          />
        </span>
        <span>
          <label htmlFor="date">Travel Date</label>
          <input
            type="date"
            name="date"
            value={this.state.date}
            onChange={this.onDateChange}
          />
        </span>
        <button type="button" onClick={this.onClick}>
          Search
        </button>
      </div>
    );
  }
}
