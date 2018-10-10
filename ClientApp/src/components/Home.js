import React, { Component } from 'react';

export class Home extends Component {
  displayName = Home.name

  constructor(props) {
    super(props);
    this.state = { luvut: [] };
  }

  componentWillMount() {

    let that = this;
    console.log("Aloitetaan data haku.");
    fetch('api/customer/luvut')
      .then(function (response) {
        return response.json();
      })
      .then(function (myJson) {
        console.log(JSON.stringify(myJson));
        that.setState({ luvut: myJson});
      });

  }

  render() {

    console.log("Render-metodissa.");

    return (
      <div>
        <h1>Riikan oma webdemo</h1>
        <p>Tervetuloa! testing testing jaadajaada lisää tekstiä Welcome to your new single-page application, built with:</p>
        <p>{this.state.luvut}</p>
      </div>
     
    );
  }
}
