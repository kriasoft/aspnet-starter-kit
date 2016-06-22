import React from 'react';
import Layout from '../Layout';

class HomePage extends React.Component {

  componentDidMount() {
    document.title = 'ASP.NET Core Starter Kit';
  }

  render() {
    return (
      <Layout>
        <h1>Home Page</h1>
        <p>Coming soon.</p>
      </Layout>
    )
  }

}

export default HomePage;
