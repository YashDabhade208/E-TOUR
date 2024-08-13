import React from 'react'
import { useNavigate } from 'react-router-dom'



const Eventbased = () => {
  const navigate = useNavigate();
  const handlebooking = (tourId) => {
    navigate(`/TourDetails/${tourId}`); 
};
  return (
    <div className="grid-container" >
    <div className="card" style={{ backgroundImage: `url(https://th.bing.com/th?id=OIP.0teqvh4Db5cg-wO072dpbgHaFk&w=288&h=216&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2)`, backgroundSize: 'cover', backgroundPosition: 'center', color: 'white', marginBottom: '100px',}}>
       <div className="card-body">
          <h1 style={{color:'white'}}>BORDER GAVASKAR TROPHY </h1>
          
          <button onClick={()=>handlebooking(7)}  style={{ backgroundColor: '#ff6347', color: 'white', padding: '10px 20px', border: 'none', borderRadius: '5px', cursor: 'pointer' }}>Book Now</button>
       </div>
    </div>

   
    </div>

  )
}

export default Eventbased