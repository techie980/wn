import React, {useState, useEffect} from 'react';
import './App.css';

function App() {
  const [darkMode, setDarkMode] = useState(false);
  // Load saved theme
  useEffect(() => {
    const savedTheme = localStorage.getItem("theme");
    if (savedTheme === "dark"){
      setDarkMode(true);
    }
  }, [])

  // save theme and update body
  useEffect(() => {
    if (darkMode) {
      document.body.className = "dark";
        localStorage.setItem("theme", "dark");
    }
    else {
      document.body.className = "light";
      localStorage.setItem("theme", "light");
    }
  }, [darkMode])
  return (
    <div className="container">
      <h1>Light / Dark Mode</h1>
      <button onClick={() => setDarkMode(!darkMode)}>
        {
          darkMode ? "☀️ Light Mode" : "🌙 Dark Mode"
        }
      </button>
        <p>
          Current Mode:
          {
              darkMode ? " Dark" : " Light"
          }
        </p>
    </div>
  );
}

export default App;
