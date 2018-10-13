import React, { Component } from "react";

import "./style.css";

import Content from "./components/shared/Content";
import Header from "./components/shared/Header";
import Nav from "./components/shared/Nav";

class App extends Component {
  render() {
    return (
      <main className="main">
        <Header />
        <Nav />
        <Content />
      </main>
    );
  }
}

export default App;
