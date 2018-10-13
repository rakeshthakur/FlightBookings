import React from "react";
import { Route, Switch } from "react-router-dom";

import Login from "../Login";
import Logout from "../Logout";
import Search from "../search/Search";
import Booking from "../booking/Booking";
import Payment from "../payment/PaymentForm";

class Content extends React.Component {
  render() {
    return (
      <div>
        <Switch>
          <Route exact path="/" component={Login} />
          <Route path="/search" component={Search} />
          <Route path="/booking" component={Booking} />
          <Route path="/payment" component={Payment} />
          <Route path="/logout" component={Logout} />
          {/* Check LOGOUT repeating */}
          <Route
            path="/logout"
            render={() => {
              return <h2>You are successfully logged out</h2>;
            }}
          />
        </Switch>
      </div>
    );
  }
}

export default Content;
