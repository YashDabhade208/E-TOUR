import React from 'react';
import './Hero.css';
import scene from "../components/Assets/scene.mp4";
import { useNavigate } from 'react-router-dom';

const Hero = () => {
 const navigate = useNavigate();
const handlegetstarted = ()=>
{
  navigate("/packages")
}
  return (
    <div className="hero">
  <video autoPlay loop muted className="background-video" style={{ width: '100%' }}>
    <source src={scene} type="video/mp4" />
  </video>
  <div className="hero-content">
    <h1>Explore the World</h1>
    <p>Your adventure starts here</p>
    <button onClick={handlegetstarted}>Get Started</button>
  </div>
</div>

  );
}

export default Hero;
