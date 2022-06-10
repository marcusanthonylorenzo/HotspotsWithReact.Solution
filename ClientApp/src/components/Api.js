import axios from 'axios';
import React from 'react'

const Api = () => {
  return (
    
    axios.get("https://localhost:5001/api/Restaurants").then((response) => console.log(response)),
    
    <div>Api</div>

   
  )
}

export default Api