import React from "react";
import Button from "./Button"
import './App.css';

function App() {
  const handleClick = () => {
    alert("Button Clicked")
  }
  return (
    <div>
        <h1>Reusable Button Example</h1>
        <Button 
          label="Click Me"
          onClick={handleClick}
          style={{
            backgroundColor: "blue",
            color: "white",
            padding: "10px 20px",
            border: "none",
            borderRadius: "5px",
            cursor: "pointer"
          }}
        />
    </div>
  );
}

export default App;
