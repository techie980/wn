import React, { useState } from 'react'
import './App.css';

function App() {
  const products = [
    { id: 1, name: "Laptop", price: 50000 }, 
    { id: 2, name: "Mobile", price: 20000 },
    { id: 3, name: "Headphones", price: 2000 },
    { id: 4, name: "Keyboard", price: 1500 },
  ];

  const [cart, setCart] = useState([]);

  const addToCart = (product) => {
    setCart([...cart, product]);
  };

  const totalPrice = cart.reduce (
    (total, item) => total + item.price, 0
  );
  
  return (
    <div className="container">
      <h1>Mini E-Commerce Cart</h1>
      <div className="products">
        <h2>Products</h2>
        {
          products.map((product) => (
            <div className="product" key={product.id} >
                <span>
                  {product.name} - ₹{product.price}
                </span>
                <button onClick={() => addToCart(product)}> Add to Cart </button>
            </div>
          ))
        }
      </div>
      <div className="cart">
          <h2>Shopping Cart</h2>
          {
            cart.length === 0 ? (
              <p>Cart is Empty</p>
            ) : 
            (
              cart.map((item, index) => {
                <p keu={index}>
                  {item.name} - ₹{item.price}
                </p>
              })
            )
          }
          <h3>Total Price: ₹{totalPrice}</h3>
      </div>
    </div>
  );
}

export default App;
