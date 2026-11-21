import React, { useState } from "react";
import './App.css';

function App() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
    function handleLogin(e) {
      e.preventDefault();
      if (username === "" || password === "") {
        alert("Please fill all fields");
      } 
      else if (password.length < 6) {
          alert("Password must be at least 6 characters");
      }
      else {
        alert("Login Succesful");
      }
    }
  return (
    <div className="container">
        <h1>Login Form</h1>
        <form onSubmit={handleLogin}>
            <label>Username: </label>
            <input 
              type="text"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
              placeholder='Enter Username'
            />
            
            <label>Password: </label>
             <input 
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              placeholder='Enter Password'
            />
            <button type="submit">
                Login
            </button>
        </form>
    </div>
  );
}

export default App;
