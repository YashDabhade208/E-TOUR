import React, { useEffect } from 'react';

const Football = () => {
  useEffect(() => {
    const fetchData = async () => {
      const url = 'https://api-football-v1.p.rapidapi.com/v2/odds/league/865927/bookmaker/5?page=2';
      const options = {
        method: 'GET',
        headers: {
          'x-rapidapi-key': '42e4fc285bmsh67d6c338cd5bcd9p1c5b77jsn5e5aa5b10e57',
          'x-rapidapi-host': 'api-football-v1.p.rapidapi.com'
        }
      };

      try {
        const response = await fetch(url, options);
        if (response.ok) { 
          const result = await response.text();
          console.log('Fetched data:', result);

          // Store the fetched data in local storage
          localStorage.setItem('footballData', result);
          console.log('Data stored in local storage:', result);
        } else {
          console.error('Error fetching data:', response.status);
        }
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div>{}</div>
  );
};

export default Football;
