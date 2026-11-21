import React, { use, useState } from "react"
import './App.css';

function App() {
  const images = [
    "https://picsum.photos/id/1015/500/300",
    "https://picsum.photos/id/1016/500/300",
    "https://picsum.photos/id/1025/500/300",
    "https://picsum.photos/id/1035/500/300",
  ];

  const [currentIndex, setCurrentIndex] = useState(0);
  const nextImage = () => {
    setCurrentIndex(
      (currentIndex + 1) % images.length
    );
  };
  const previousImage = () => {
    setCurrentIndex(
      (currentIndex - 1 + images.length) % images.length
    );
  };
  return (
    <div className="container">
        <h1>Image Gallery</h1>
        <img 
          src={images[currentIndex]}
          alt="Gallery"
          className="image"
        />
        <div className="buttons">
          <button onClick={previousImage}> Previous </button>
          <button onClick={nextImage}> Next </button>
        </div>
        <p> Image {currentIndex + 1} of {images.length} </p>
    </div>
  );
}

export default App;
