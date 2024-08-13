import React from 'react';
import './Invoice.css';
import { useLocation } from 'react-router-dom';

const Invoice = () => {
   const location = useLocation();
   const booking = location.state || {};

   const passengers = [
      { type: 'Adult', description: 'Passenger', rate: 5000, quantity: booking.numberOfPassengers || 0 },
      { type: 'Child with Bed', description: 'Passenger', rate: 3000, quantity: booking.numberOfChildrenWithBed || 0 },
      { type: 'Child without Bed', description: 'Passenger', rate: 1500, quantity: booking.numberOfChildrenWithoutBed || 0 }
   ];

   const totalPassengers = passengers.reduce((total, passenger) => total + passenger.quantity, 0);
   const totalCost = passengers.reduce((total, passenger) => total + (passenger.rate * passenger.quantity), 0);

   return (
      <div>
         <header>
            <h1>INVOICE</h1>
            <address>
               <p>Rahul Pal</p>
               <p>#429, First Floor</p>
               <p>Bettadasanapura</p>
               <p>+918660876889</p>
            </address>
            <span>
               <img alt="Rahul" src="https://logos.textgiraffe.com/logos/logo-name/Mahesh-designstyle-smoothie-m.png" className="rounded float-right align-top" />
            </span>
         </header>

         <body>
            <article>

               <table className="firstTable">
                  <tr>
                     <th><span>Invoice #</span></th>
                     <td><span>101138</span></td>
                  </tr>
                  <tr>
                     <th><span>Date</span></th>
                     <td><span>August 12, 2024</span></td>
                  </tr>
                  <tr>
                     <th><span>Package</span></th>
                     <td><span>{booking.packageName || 'N/A'}</span></td>
                  </tr>
                  <tr>
                     <th><span>Package Base Price</span></th>
                     <td><span data-prefix>₹</span><span>{booking.price || 0}</span></td>
                  </tr>
               </table>

               <table className="secondTable">
                  <thead>
                     <tr>
                        <th><span>Passenger Type</span></th>
                        <th><span>Description</span></th>
                        <th><span>Rate per person</span></th>
                        <th><span>No. of Passengers</span></th>
                        <th><span>Price</span></th>
                     </tr>
                  </thead>
                  <tbody>
                     {passengers.map((passenger, index) => (
                        <tr key={index}>
                           <td><span>{passenger.type}</span></td>
                           <td><span>{passenger.description}</span></td>
                           <td><span data-prefix>₹</span><span>{passenger.rate}</span></td>
                           <td><span>{passenger.quantity}</span></td>
                           <td><span data-prefix>₹</span><span>{passenger.rate * passenger.quantity}</span></td>
                        </tr>
                     ))}
                  </tbody>
               </table>

               <table className="firstTable">
                  <tr>
                     <th><span>Total</span></th>
                     <td><span data-prefix>₹</span><span>{totalCost}</span></td>
                  </tr>
                  <tr>
                     <th><span>Amount Paid</span></th>
                     <td><span data-prefix>₹</span><span>{/* Amount paid value */}</span></td>
                  </tr>
               </table>
            </article>
         </body>
      </div>
   );
}

export default Invoice;
