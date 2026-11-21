import React from 'react'
import './App.css';

function App() {
  return (
    <div>
        <nav className="navbar">
          <h2>My Website</h2>
          <ul>
            <li>Home</li>
            <li>About</li>
            <li>Services</li>
            <li>Contact</li>
          </ul>
        </nav>
        <div className="content">
          <h1>Sticky Navbar Example</h1>
          <p>
            Scroll down to see the navbar remain fixed at the top.
          </p>
          {
            [...Array(30)].map((_, index) => (
              <p key={index}>
                  This is sample content line {index + 1}
              </p>
            ))
          }
        </div>
    </div>
  );
}

export default App;
