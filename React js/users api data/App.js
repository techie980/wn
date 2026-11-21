import React, {useEffect, useState} from "react";
import './App.css';

function App() {
  const [users, setUsers] = useState([]);
  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/users")
    .then((response) => response.json())
    .then((data) => { setUsers(data); });
  }, []);

  return (
    <div className="container">
      <h1>User Details</h1>
      <table>
          <thead>
              <tr>
                  <th>ID</th>
                  <th>Name</th>
                  <th>Email</th>
                  <th>City</th>
              </tr>
          </thead>
          
          <tbody>
            {
              users.map((user) => (
                <tr key={user.id}>
                    <td>
                      {user.id}
                    </td>
                    <td>
                      {user.name}
                    </td>
                    <td>
                      {user.email}
                    </td>
                    <td>
                      {user.address.city}
                    </td>
                </tr>
              ))
            }
          </tbody>
      </table>
    </div>
  );
}

export default App;
