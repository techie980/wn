
import React, { useState } from "react";
import './App.css';

function App() {
  const [progress, setProgress] = useState(0);
  const handleSlider = (e) => {
    setProgress(e.target.value);
  };

  return (
    <div className="container">
      <h1>Progress Bar</h1>
      <div className="progress-container">
        <div className="progress-bar" style={{ width: `${progress}%` }}>
            {progress}%
        </div>
      </div>
      <input 
        type="range"
        min="0"
        max="100"
        value={progress}
        onChange={handleSlider}
      />    
      <h3>
        Progress: {progress}%
      </h3>
    </div>
  );
}

export default App;
