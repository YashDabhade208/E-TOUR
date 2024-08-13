import React, { useEffect, useState } from 'react';
import { useLocation, useNavigate, useParams } from 'react-router-dom';
import jsPDF from 'jspdf';
import 'jspdf-autotable';
import './PaymentPage.css';

const PaymentPage = () => {
  const [costDetails, setCostDetails] = useState(null);
  const [totalCost, setTotalCost] = useState(0);
  const location = useLocation();
  const navigate = useNavigate();
  const { passengerCount, childWithBedCount, childWithoutBedCount } = location.state || {};
  const { tourId } = useParams();
  
  useEffect(() => {
    const fetchCostDetails = async () => {
      try {
        const response = await fetch(`http://localhost:8080/api/costs/${tourId}`);
        if (!response.ok) {
          throw new Error(`HTTP error! Status: ${response.status}`);
        }
        const data = await response.json();
        setCostDetails(data);
      } catch (error) {
        console.error('Error fetching cost details:', error);
      }
    };

    fetchCostDetails();
  }, [tourId]);

  useEffect(() => {
    if (costDetails) {
      const { singlePersonCost, childWithBedCost, childWithoutBedCost } = costDetails;
      const calculatedTotalCost =
        passengerCount * singlePersonCost +
        childWithBedCount * childWithBedCost +
        childWithoutBedCount * childWithoutBedCost;
      setTotalCost(calculatedTotalCost);
    }
  }, [costDetails, passengerCount, childWithBedCount, childWithoutBedCount]);

  const handlePayment = () => {
    console.log('Proceeding to payment...');
    navigate('/confirmation', { state: { totalCost } });
  };

  const generateInvoice = () => {
    const doc = new jsPDF();
    
    doc.text('Invoice', 14, 22);
    doc.setFontSize(12);
    doc.text(`Tour ID: ${tourId}`, 14, 32);
    doc.text(`Passenger Count: ${passengerCount}`, 14, 42);
    doc.text(`Children with Bed Count: ${childWithBedCount}`, 14, 52);
    doc.text(`Children without Bed Count: ${childWithoutBedCount}`, 14, 62);
    doc.text(`Total Cost: $${totalCost}`, 14, 72);

    // Add AutoTable for better formatting
    doc.autoTable({
      startY: 82,
      head: [['Description', 'Amount']],
      body: [
        ['Cost per Adult', `$${costDetails?.singlePersonCost}`],
        ['Cost per Child with Bed', `$${costDetails?.childWithBedCost}`],
        ['Cost per Child without Bed', `$${costDetails?.childWithoutBedCost}`],
        ['Total Cost', `$${totalCost}`],
      ],
    });

    doc.save('invoice.pdf');
  };

  return (
    <div className="payment-page">
      <h1 className="payment-title">Complete Your Payment</h1>
      <div className="payment-summary">
        <h2>Booking Summary</h2>
        {costDetails ? (
          <div className="summary-details">
            <p><strong>Cost per Adult:</strong> ${costDetails.singlePersonCost}</p>
            <p><strong>Cost per Child with Bed:</strong> ${costDetails.childWithBedCost}</p>
            <p><strong>Cost per Child without Bed:</strong> ${costDetails.childWithoutBedCost}</p>
            <hr />
            <h3><strong>Total Cost:</strong> ${totalCost}</h3>
          </div>
        ) : (
          <p>Loading cost details...</p>
        )}
      </div>

      <div className="payment-details">
        <h2>Enter Payment Details</h2>
        <form>
          <div className="form-group">
            <label> Name</label>
            <input type="text" placeholder="Enter your name" required />
          </div>
          
          <div className="form-group">
            <label>Booking Date</label>
            <input type="text" placeholder="MM/YY" required />
          </div>
          <div className="form-group">
            <label>CVV</label>
            <input type="text" placeholder="CVV" required />
          </div>
        </form>
      </div>

      <button className="pay-now-button" onClick={handlePayment}>
        Proceed to Pay ${totalCost}
      </button>
      <br />
      <button className="pay-now-button" onClick={generateInvoice}>
        Download Invoice as PDF
      </button>
    </div>
  );
};

export default PaymentPage;
