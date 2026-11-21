import React, { useState } from "react";
import './App.css';

function App() {
  const [activeTab, setActiveTab] = useState("Home");
  const renderContent = () => {
    if (activeTab === "Home") {
      return (
        <div>
          <h2>Home Tab</h2>
          <p>Welcome to Home Page</p>
        </div>
      );
    }
    if (activeTab === "About") {
      return (
        <div>
          <h2>About Tab</h2>
          <p>We Provide Development Software ToolKits</p>
        </div>
      );
    }
    if (activeTab === "Contact") {
      return (
        <div>
          <h2>Contact Tab</h2>
          <p>Contact us Here</p>
        </div>
      );
    }
  }
  return (
    <div className="container">
        <h1>Tabbed Interface</h1>
        <div className="tabs">
            <button className={activeTab == "Home" ? "active" : ""} onClick={() => setActiveTab("Home")}>
                Home
            </button>
            <button className={activeTab == "About" ? "active" : ""} onClick={() => setActiveTab("About")}>
                About
            </button>
            <button className={activeTab == "Contact" ? "active" : ""} onClick={() => setActiveTab("Contact")}>
                Contact
            </button>
        </div>
        <div className="content">
          {renderContent()}
        </div>
    </div>
  );
}

export default App;
