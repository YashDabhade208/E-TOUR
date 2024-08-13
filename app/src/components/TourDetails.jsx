import React, { useState, useEffect } from 'react';
import './TourDetails.css';
import Placeholder from 'react-bootstrap/Placeholder';
import { useNavigate, useParams } from 'react-router-dom';

const TourDetails = () => {
  const [tourData, setTourData] = useState(null);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);
  const navigate = useNavigate();
  const { tourId } = useParams(); 

  useEffect(() => {
    fetchData();
  }, [tourId]);

  const handleBooking = () => {
    navigate(`/BookingPage/${tourId}`);
  };

  const fetchData = async () => {
    setIsLoading(true);
    setError(null);

    try {
      const response = await fetch(`http://localhost:8080/api/tours/${tourId}`);
      if (!response.ok) {
        throw new Error();
      }

      const data = await response.json();
      setTourData(data);
    } catch (error) {
      console.error('Error fetching tour data:', error);
      setError('Failed to fetch tour data. Please try again.');
    } finally {
      setIsLoading(false);
    }
  };
  
  const getImageUrl = () => {
    switch (tourId) {
      case '1':
        return 'https://www.planetware.com/wpimages/2020/11/europe-top-attractions-colosseum-rome.jpg';
      case '2':
        return 'https://images.pexels.com/photos/2259917/pexels-photo-2259917.jpeg?auto=compress&cs=tinysrgb&w=600';
      case '3':
        return 'https://images.pexels.com/photos/2070485/pexels-photo-2070485.jpeg?auto=compress&cs=tinysrgb&w=600'; 
      case '4':
        return 'https://cdn.pixabay.com/photo/2017/06/12/15/55/bharat-2395926_640.jpg'; 
      case '5':
        return 'https://images.pexels.com/photos/962464/pexels-photo-962464.jpeg?auto=compress&cs=tinysrgb&w=600';
      case '6':
        return 'https://media.gettyimages.com/id/1211749825/photo/tea-garden-against-foggy-mountains.jpg?s=612x612&w=0&k=20&c=rJnn7_jHZqprvI2bT65PH55_4Fy5ae_LUH3-ZL-DFQQ=';
      case '7':
        return 'https://media.gettyimages.com/id/1473176202/photo/ahmedabad-india-india-celebrate-after-they-retained-the-border-gavaskar-trophy-on-day-five-of.jpg?s=612x612&w=0&k=20&c=AIBv7LwD8Z8qcqfIodZVcKBBwaU5y9wmHVflP6L0BRI=';
      default:
        return 'https://example.com/default-image.jpg';
    }
  };

  return (
    <div> 
    <div className="tour-details-container">
    <h1 style={{marginleft:'10cm'}}>Tour Details</h1>
      {isLoading && <Placeholder as="p" animation="glow">Loading...</Placeholder>}
      {error && <p className="error-message">{error}</p>}
      {tourData && (
        <div className="tour-data-wrapper">
          <div className="tour-header">
            <img
              src={getImageUrl()} 
              alt={tourData.name}
              className="tour-image"
            />
            <div className="tour-header-info">
              <h1 className="tour-name">{tourData.name}</h1>
              <p className="tour-destination">{tourData.destination}</p>
              <p className="tour-duration">Duration: {tourData.duration} days</p>
              <p className="tour-cost">Cost: ${tourData.cost}</p>
            </div>
          </div>
          <div className="tour-description">
            <h2>About this Tour</h2>
            <p>{tourData.description}</p>
          </div>
          <div className="tour-includes">
            <h2>Itineraries</h2>
            <ul>
              {tourData.itineraries.map((itinerary) => (
                itinerary.description && itinerary.date ? (
                  <li key={itinerary.id}>
                    <strong>{itinerary.date}:</strong> {itinerary.description}
                  </li>
                ) : null
              ))}
            </ul>
          </div>
        </div>
      )}
      <div className="booking-section">
        <button className="book-now-button" onClick={handleBooking}>
          Book Now
        </button>
      </div>
    </div>
    </div>
  );
};

export default TourDetails;
