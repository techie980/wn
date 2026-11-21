import React, { useState } from 'react'
import './App.css';

function App() {
  const [searchWord, setSearchWord] = useState("");
  const paragraph = "React is a Javascript library used for building user interfaces, React allows developers to create reusable components and interactive web applications.";
  const highlightText = () => {
    if (!searchWord) {
      return paragraph;
    }
    const parts = paragraph.split(
      new RegExp(`(${searchWord})`, "gi")
    );
    return parts.map((part, index) => 
      part.toLowerCase() === searchWord.toLowerCase() ? (
        <span key={index} className='highlight'>
            {part}
        </span>
      ) : (
        part
      )
    );
  };

  return (
    <div className="container">
      <h1>Word Highlight App</h1>
      <input 
        type='text'
        placeholder='Search a word...'
        value={searchWord}
        onChange={(e) => setSearchWord(e.target.value)}
      />
      <p className='paragraph'>
        {highlightText()}
      </p>
    </div>
  );
}

export default App;
