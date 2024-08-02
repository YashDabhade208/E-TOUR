import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Login from './LoginPage';
import Register from "./RegisterPage";


function Main() {
   return (
      <div>
         <Router>
            <Routes>
               <Route path="/login" element={<Login />} />
               <Route path="/register" element={<Register />} />
            </Routes>
         </Router>
     </div> 
   );
}

export default Main;