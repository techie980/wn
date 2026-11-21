import React, { useEffect, useState } from 'react'
import './App.css';

function App() {
  const [posts, setPosts] = useState([]);
  const [search, setSearch] = useState("");
  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((response) => response.json())
      .then((data) => setPosts(data))
  }, []);

  const filteredPosts = posts.filter((post) =>
    post.title.toLowerCase().includes(search.toLowerCase())
  );

  return (
    <div className="container">
      <h1>Blog Post Viewer</h1>
      <input 
        type="text"
        placeholder="Search by title..."
        value={search}
        onChange={(e) => setSearch(e.target.value)}
      />
      <div className="posts"> 
        {
          filteredPosts.map((post) => (
            <div className="post" key={post.id}>
              <h3>{post.title}</h3>
              <p>{post.body}</p>
            </div>
          ))
        }
      </div>
    </div>
  );
}

export default App;
