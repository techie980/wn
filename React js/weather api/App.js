import React, { useState } from "react";
import './App.css';

function App() {
  const [city, setCity] = useState("");
  const [weather, setWeather] = useState(null);
  const [error, setError] = useState("");
  const API_KEY = "6f8c1a9a552216dace27c50c74d29662";

  async function getWeather() {
    if (city === "") {
      setError("Please enter a city name");
      return;
    }
    try {
      const response = await fetch(`https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=${API_KEY}&units=metric`);
        const data = await response.json();

        if (data.cod === "404") {
            setError("City not found");
            setWeather(null);
            return;
        }
        setWeather(data);
        setError("");
    }
    catch(error){
        setWeather("Something went wrong");
    }
  }

  return (
    <div className="container">
        <h1>Weather App</h1>
        <input type="text" placeholder="Enter City" value={city} 
          onChange={(e) => setCity(e.target.value)} 
        />
        <button onClick={getWeather}>
            Search
        </button>
        <h3>{error}</h3>
        {
          weather && (
            <div className="weather-box">
                <h2>{weather.name}</h2>
                <p>
                  Temperature: {weather.main.temp} °C
                </p>
                <p>
                  Weather: {weather.weather[0].description}
                </p>
                <p>
                  Humidity: {weather.main.humidity}%
                </p>
            </div>
          )
        }
    </div>
  );
}

export default App;
