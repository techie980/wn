import React, { useState } from "react"
import './App.css';

function App() {
  const [step, setStep ] = useState(1);
  const [formData, setFormData] = useState({
    name: "",
    email: "",
    address: ""
  });
  const handleChange = (e) => {
    setFormData({
      ...formData, [e.target.name] : [e.target.value] 
    });
  };
  const nextStep = () => {
    setStep(step + 1);
  };
  const previousStep = () => {
    setStep(step - 1);
  };
  const submitForm = () => {
    alert("Form Submitted Successfully");
  };
  return (
    <div className="container">
      <h1>Multi-Step Form</h1>
      {
        step === 1 && (
          <div>
            <h2>Step 1: Personal Details</h2>
            <label>Name: </label>
            <input type="text" name="name" value={formData.name} onChange={handleChange} />
          </div>
        )
      }
      {
        step === 2 && (
          <div>
            <h2>Step 2: Contact Details</h2>
            <label>Email: </label>
            <input type="email" name="email" value={formData.email} onChange={handleChange} />
          </div>
        )
      }
      {
        step === 3 && (
          <div>
            <h2>Step 3: Address Details</h2>
            <label>Address: </label>
            <textarea name="address" value={formData.address} onChange={handleChange} />
          </div>
        )
      }
      <div className="buttons">
          {
            step > 1 && (
              <button onClick={previousStep}> Back </button>
            )
          }
          {
            step < 3 && (
              <button onClick={nextStep}> Next </button>
            )
          }
          {
            step === 3 && (
              <button onClick={submitForm}> Submit </button>
            )
          }
      </div>
      <div className="preview">
          <h3>Form Data Preview</h3>
          <p>Name: {formData.name}</p>
          <p>Email: {formData.email}</p>
          <p>Address: {formData.address}</p>
      </div>
    </div>
  );
}

export default App;
