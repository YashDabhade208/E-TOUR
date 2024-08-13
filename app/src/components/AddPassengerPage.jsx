import axios from 'axios';
import React, { useState } from 'react';
import './AddPassengerPage.css';

const AddPassengerPage = ({ numberOfPassengers, onPassengerDetailChange }) => {
   const [passengerDetails, setPassengerDetails] = useState(
      Array.from({ length: numberOfPassengers }, () => ({
         name: '',
         age: '',
         gender: '',
         mobileNo: '',
         email: '',
         aadhaarNo: '',
      }))
   );

   const handleDetailChange = (index, field) => (e) => {
      const newDetails = [...passengerDetails];
      newDetails[index][field] = e.target.value;
      setPassengerDetails(newDetails);
      onPassengerDetailChange(index, field, e.target.value);
   };

   const handleSavePassengers = async () => {
      try {
         const response = await axios.post('http://localhost:8080/api/passengers', passengerDetails, {
            headers: {
               'Content-Type': 'application/json',
            },
         });
         console.log('Passengers saved successfully:', response.data);
      } catch (error) {
         console.error('Error saving passengers:', error);
      }
   };

   return (
      <div>
         <h2>Passenger Details</h2>
         {passengerDetails.map((_, index) => (
            <div key={index}>
               <h3>Passenger {index + 1}</h3>
               <label>Name:</label>
               <input
                  type="text"
                  value={passengerDetails[index].name}
                  onChange={handleDetailChange(index, 'name')}
               />
               <br />
               <label>Age:</label>
               <input
                  type="number"
                  value={passengerDetails[index].age}
                  onChange={handleDetailChange(index, 'age')}
               />
               <br />
               <label>Gender:</label>
               <select
                  value={passengerDetails[index].gender}
                  onChange={handleDetailChange(index, 'gender')}
               >
                  <option value="">Select</option>
                  <option value="Male">Male</option>
                  <option value="Female">Female</option>
                  <option value="Other">Other</option>
               </select>
               <br />
               <label>Mobile No:</label>
               <input
                  type="tel"
                  value={passengerDetails[index].mobileNo}
                  onChange={handleDetailChange(index, 'mobileNo')}
               />
               <br />
               <label>Email:</label>
               <input
                  type="email"
                  value={passengerDetails[index].email}
                  onChange={handleDetailChange(index, 'email')}
               />
               <br />
               <label>Aadhaar No:</label>
               <input
                  type="text"
                  value={passengerDetails[index].aadhaarNo}
                  onChange={handleDetailChange(index, 'aadhaarNo')}
               />
               <br />
            </div>
         ))}
         <button onClick={handleSavePassengers}>Save Passengers</button>
      </div>
   );
};

export default AddPassengerPage;