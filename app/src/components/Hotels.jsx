import React, { useState, useEffect } from 'react';

const Hotels = () => {
  const [data, setData] = useState(null);
  const [locationId, setLocationId] = useState('304554'); // New state for location ID
  const url = `https://tripadvisor16.p.rapidapi.com/api/v1/restaurant/searchRestaurants?locationId=${locationId}`;
  const options = {
    method: 'GET',
    headers: {
      'x-rapidapi-key': '42e4fc285bmsh67d6c338cd5bcd9p1c5b77jsn5e5aa5b10e57',
      'x-rapidapi-host': 'tripadvisor16.p.rapidapi.com'
    }
  };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(url, options);
        const result = await response.text();
        setData(result);
        console.log(result) // Set the fetched data to state
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };

    fetchData();
  }, [locationId]); // Fetch data whenever locationId changes

  const handleLocationIdChange = (e) => {
    setLocationId(e.target.value);
  };

  return (
    <div>
      <input
        type="text"
        value={locationId}
        onChange={handleLocationIdChange}
        placeholder="Enter location ID (e.g., 304554)"
      />
      <div>
        {data ? (
          <pre>{data}</pre>
        ) : (
          <p>Loading...</p>
        )}
      </div>
    </div>
  );
};

export default Hotels;
