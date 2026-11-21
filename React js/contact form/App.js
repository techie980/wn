import React, { useState } from "react";
import "./App.css";
function App() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [message, setMessage] = useState("");
  const [submittedData, setSubmittedData] = useState(null);

  function handleSubmit(e) {
    e.preventDefault();
    setSubmittedData({
      name: name,
      email: email,
      message: message
    });
    setName("");
    setEmail("");
    setMessage("");
  }

  return (
    <div className="container">
        <h1>Contact Form</h1>
        <form onSubmit={handleSubmit}>
            <label>Name: </label>
            <input type="text" value={name} onChange={(e) => setName(e.target.value)}/>
              
            <label>Email: </label>
            <input type="email" value={email} onChange={(e) => setEmail(e.target.value)}/>

            <label>Message: </label>
            <textarea value={message} onChange={(e) => setMessage(e.target.value)}/>
            <button type="submit">Submit</button>
        </form>
        {
          submittedData && 
          <div className="result">
              <h2>Submitted Data</h2>
              <p>
                <b>Name: </b> {submittedData.name}
              </p>
               <p>
                <b>Email: </b> {submittedData.email}
              </p>
               <p>
                <b>Message: </b> {submittedData.message}
              </p>
          </div>
        }
    </div>
  );
}

export default App;