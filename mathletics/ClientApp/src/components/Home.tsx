import React, { useState, useEffect } from 'react';
// import { connect } from 'react-redux';


const getQuestions = async () => {
  const response = await fetch('/api/Questions/GetAll');
  const questions = await response.json();
  return questions;
}



export default function Home() {
  const [quiz, setQuiz] = useState([]);

  useEffect(() => {
    getQuestions().then(list => {      
      setQuiz(list)
    })
  }, [])


  return (
    <div>
      <h1>All of the sweet questions</h1>
      {quiz.map((question, index) => {
        return (
          <div key={index}>
            <h4>Question {question['prompt']}</h4>
            <button>{question['option1']}</button>
            <button>{question['option2']}</button>
            <button>{question['option3']}</button>            
          </div>
        )
      })}

    </div>
  )
};