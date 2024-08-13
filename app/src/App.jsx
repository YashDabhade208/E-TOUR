import React from 'react';
import "./App.css"
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Main from './components/Main';
import Navbarr from './components/Navbarr';
import Home from './components/Home';
import Domestic from './components/Domestic';
import Login from './components/LoginPage';
import Packages from './components/Packages';
import Register from './components/RegisterPage';
import International from './components/International';
import ContactUs from './components/ContactUs';
import AboutUs from './components/AboutUs';
import './App.css';
import Footer from './components/Footer';
import Eventbased from './components/Eventbased';
import BookingPage from './components/BookingPage';
import TourDetails from './components/TourDetails';
import PaymentPage from './components/PaymentPage';

function App() {
  return (
    
   <div style={{overflow:'hidden'}}>
   <Router>
    <Navbarr />
      
         
      
      <Routes>
       
      
        <Route path="/" element={<Home />} />
        <Route path="/Packages" element={<Packages />} />
        <Route path="/Login" element={<Login />} />
        <Route path="/main" element={<Main />} />
        <Route path="/Domestic" element={<Domestic />} />
        <Route path="/International" element={<International />} />
        <Route path="/Eventbased" element={<Eventbased />} />
        <Route path="/Register" element={<Register />} />
        <Route path="/AboutUs" element={<AboutUs />} />
        <Route path="/ContactUs" element={<ContactUs />} />
        <Route path="/BookingPage/:tourId" element={<BookingPage/>} />
        
        <Route path="/TourDetails/:tourId" element={<TourDetails />} />
        <Route path="/PaymentPage/:tourId" element={<PaymentPage/>} />
       
        

      </Routes>
      <Footer/>
    </Router>
   </div>
   
   
    
    
  );
}

export default App;