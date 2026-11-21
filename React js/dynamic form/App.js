import React, {useState} from 'react'
import './App.css';

function App() {
  const [inputs, setInputs] = useState([""]);
  const handleChange = (index, event) => {
    const values = [...inputs];
    values[index] = event.target.value;
    setInputs(values);
  };

  const addInput = () => {
    setInputs([...inputs, ""]);
  }

  const removeInput = (index) => {
    const values = [...inputs];
    values.splice(index, 1);
    setInputs(values);
  }
  return (
    <div className="container">
        <h1>Dynamic Form</h1>
        {
          inputs.map((input, index) => (
            <div className="input-group" key={index}>
                <input 
                  type="text"
                  placeholder={`Enter Value ${index + 1}`}
                  value={input}
                  onChange={(event) => handleChange(index, event)}
                />
                <button className="remove" onClick={() => removeInput(index)}>
                  Remove
                </button>
            </div>
          ))
        }
        <button className="add" onClick={addInput}>Add Input</button>
    </div>
  );
}

export default App;
