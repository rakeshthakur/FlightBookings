import React from "react";
import { Link } from "react-router-dom";

class Nav extends React.Component {
  render() {
    return (
      <nav className="nav">
        <div>
          <Link to="/Search">Search</Link>
        </div>
        <div>
          <Link to="/Bookings">Bookings</Link>
        </div>
        <div>
          <Link to="/logout">Logout</Link>
        </div>
      </nav>
    );
  }
}

export default Nav;
