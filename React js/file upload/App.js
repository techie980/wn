import React, {useState} from 'react'
import './App.css';

function App() {
  const [fileName, setFileName] = useState("No file Selected");
  const handleFileChange = (event) => {
    if (event.target.files.length > 0) {
      setFileName(event.target.files[0].name);
    }
    else {
      setFileName("No file Selected");
    }
  };

  return (
    <div className="container">
        <h1>File Upload Form</h1>
        <input 
          type="file"
          onChange={handleFileChange}
        />
        <h3>
          Selected File 
        </h3>
        <p>{fileName}</p>
    </div>
  );
}

export default App;
