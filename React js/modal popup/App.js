import React, { useState } from "react";
import './App.css';

function App() {
  const [showModal, setShowModal] = useState(false);

  return (
    <div className="container">
      <h1>Modal Popup Example</h1>
      <button className="open-btn" onClick={() => setShowModal(true)}>
        Open Modal
      </button>
      {
        showModal && (
          <div className="modal-overlay" onClick={() => setShowModal(false)}>
            <div className="modal-box" onClick={(e) => e.stopPropagation()}>
                <button className="close-btn" onClick={() => setShowModal(false)}>
                      X
                </button>
                <h2>Modal Popup</h2>
                <p>This is a modal Popup window</p>
                <p>Click Outside or pass X to close</p>
            </div>
          </div>
        )
      }
    </div>
  );
}

export default App;
