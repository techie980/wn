import React, { useState } from "react" 
import './App.css';

function App() {
  const [showMenu, setShowMenu] = useState(false);
  return (
    <div className="container">
      <h1>Dropdown Menu Example</h1>
      <div className="dropdown">
        <button className="dropdown-btn" onClick={() => setShowMenu(!showMenu)}>
            Menu ▼
        </button>
        {
          showMenu && (
            <div className="menu">
              <p>Home</p>
              <p>Profile</p>
              <p>Settings</p>
              <p>Logout</p>
            </div>
          )
        }
      </div>
    </div>
  );
}

export default App;
