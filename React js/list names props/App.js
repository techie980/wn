import React from 'react';
import NameCard from "./NameCard";
import './App.css';

function App() {
  const names = ["Rahul", "Amit", "Shubham", "Aniket", "Pranav", "Avishkar", "Girish"];
  return (
    <div className="container">
      <h1>Name Card List</h1>
      <NameCard names={names} />
    </div>
  );
}

export default App;
