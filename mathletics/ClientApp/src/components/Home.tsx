import React from 'react';
// import { connect } from 'react-redux';


const getQuestions = async questions => {
  const response = await fetch('/api/Questions/GetAll');
  const forecasts = await response.json();
  props.dispatch({ type: 'ADD_LINK', value: { link: forecasts.title, votes: 0 } });
  console.log(props);
}


export default function Home(){
  return(
    <div>
      <h1>All of the sweet questions</h1>
    </div>
)};