import React, {use, useState} from "react";
import './App.css';

function App() {
  const questions = [
    {
      question: "What is the capital of India?",
      options: ["Mumbai", "Delhi", "Chennai", "Kolkata"],
      answer: "Delhi"
    },
    {
      question: "Which language is used for React?",
      options: ["Python", "Java", "JavaScript", "C++"],
      answer: "JavaScript"
    },
    {
      question: "Which HTML tag is used for a paragraph?",
      options: ["<p>", "<h1>", "<div>", "<span>"],
      answer: "<p>"
    },
    {
      question: "Which of the following is a Button Event Handler?",
      options: ["border", "submit", "useState", "onClick"],
      answer: "onClick"
    },
  ]
  const [currentQuestion, setCurrentQuestion] = useState(0);
  const [selectedAnswer, setSelectedAnswer] = useState("");
  const [score, setScore] = useState(0);
  const [showScore, setShowScore] = useState(false);

  const handleAnswer = (option) => {
    setSelectedAnswer(option);
  };

  const nextQuestion = () => {
    if (selectedAnswer === questions[currentQuestion].answer) {
        setScore(score + 1);
      }
      setSelectedAnswer("");
      if (currentQuestion < questions.length - 1) {
          setCurrentQuestion(currentQuestion + 1);
      }
      else {
        setShowScore(true);
      }
    };
  return (
    <div className="container">
        <h1>Quiz App</h1>
        {
          showScore ? (
            <div className="score">
                <h2>
                  Your Score: {score} / {questions.length}
                </h2>
            </div> 
          ) : (
            <div className="quiz">
                <h2>
                  {questions[currentQuestion].question}
                </h2>
                {questions[currentQuestion].options.map((option, index) => (
                  <button key={index} className={selectedAnswer === option ? "selected" : ""}
                      onClick={() => handleAnswer(option)}>
                      {option}
                  </button>
                ))}
                <button className="next" onClick={nextQuestion} disabled={!selectedAnswer}>
                  Next
                </button>
            </div>
          )
        }
    </div>
  );
}

export default App;
