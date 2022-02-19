import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { finests: [], loading: true };
  }

    componentDidMount() {
        this.getDataFromApi();
  }

    static renderTable(finests) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Description</th>
          </tr>
        </thead>
        <tbody>
                {finests.map(e =>
                    <tr key={e.id}>
                        <td>{e.id}</td>
              <td>{e.name}</td>
              <td>{e.description}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : FetchData.renderTable(this.state.finests);

    return (
      <div>
            <h1 id="tabelLabel" >finests</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
      </div>
    );
  }

  async getDataFromApi() {
    const response = await fetch('api/Finest');
    const data = await response.json();
    this.setState({ finests: data, loading: false });
  }
}
