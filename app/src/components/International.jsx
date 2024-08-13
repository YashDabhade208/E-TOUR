import React from 'react'
import nashik_monsoon from '../components/Assets/nashik_monsoon.jpg'
import kerla2 from '../components/Assets/kerla2.jpg'
import './International.css'
import { useNavigate } from 'react-router-dom';

const International = () => {

   const navigate = useNavigate();

   const handlebooking = (tourId) => {
      navigate(`/TourDetails/${tourId}`); 
  };
 
  const tours = [
   { id: 1, name: "International" },
   { id: 2, name: "Domestic" },
   { id: 3, name: "Event-based" }, // Adjust videoSrc as needed
 ];


  return (
     <><div className="grid-container"> 
        <div className="card" style={{ backgroundImage: `url(${"https://a.travel-assets.com/findyours-php/viewfinder/images/res70/56000/56828-Dubai.jpg"})`, backgroundSize: 'cover', backgroundPosition: 'center', color: 'white', marginBottom: '26px', height: '30vh', backgroundPositionY: '-250px' }}>
           <div className="card-body" >
              <h1 style={{ color: 'white' }}>Dubai Safar</h1>
             

              <button onClick={()=>handlebooking(1)} style={{ backgroundColor: '#ff6347', color: 'white', padding: '10px 20px', border: 'none', borderRadius: '5px', cursor: 'pointer' }}>
                 Book Now
              </button>
           </div>
        </div>

        <div className="card" style={{ backgroundImage: `url(${"https://www.qantas.com/images/qantas/destinations/new-zealand-and-south-pacific/queenstown-mountains/jpg/hero.desktop.jpg"})`, backgroundSize: 'cover', backgroundPosition: 'center', color: 'white,', marginBottom: '26px', height: '30vh' }}>
           <div className="card-body">
              <h1 style={{ color: 'white' }}>New Zealand </h1>
             

              <button onClick={()=>handlebooking(2)} style={{ backgroundColor: '#ff6347', color: 'white', padding: '10px 20px', border: 'none', borderRadius: '5px', cursor: 'pointer' }}>
                 Book Now
              </button>
           </div>
        </div>

        <div className="card" style={{ backgroundImage: `url(${"https://th.bing.com/th?id=OIP.Pyi5AcmaDQGCLRI8sA4N-wHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2"})`, backgroundSize: 'cover', backgroundPosition: 'center', color: 'white',marginBottom: '26px', height: '30vh' }}>
           <div className="card-body">
              <h1 style={{ color: 'white' }}>Thailand Tour</h1>
              
              <button onClick={()=>handlebooking(3)} style={{ backgroundColor: '#ff6347', color: 'white', padding: '10px 20px', border: 'none', borderRadius: '5px', cursor: 'pointer' }}>
                 Book Now
              </button>
           </div>
        </div>
        </div>
     </>
  )
}

export default International;