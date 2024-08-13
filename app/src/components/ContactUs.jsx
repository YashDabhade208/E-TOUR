import React from "react";
import { useState,useEffect,useRef } from "react";
import "./ContactUs.css";
function ContactUs() {
   const [result, setResult] = React.useState("");
 
   const onSubmit = async (event) => {
     event.preventDefault();
     setResult("Sending....");
     const formData = new FormData(event.target);
 
     formData.append("access_key", "45784bb7-6726-4e8a-a815-78720bb67e8a");
 
     const response = await fetch("https://api.web3forms.com/submit", {
       method: "POST",
       body: formData
     });
 
     const data = await response.json();
 
     if (data.success) {
       setResult("Form Submitted Successfully");
       event.target.reset();
     } else {
       console.log("Error", data);
       setResult(data.message);
     }
   };
 
   
      return (
         <div className="contact-container">
            <h1>Contact Us</h1>
           <form className="contact-form" onSubmit={onSubmit}>
             <input type="hidden" name="access_key" value="45784bb7-6726-4e8a-a815-78720bb67e8a" />
             <input type="text" name="name" required className="contact-input" placeholder="Your Name" />
             <input type="email" name="email" required className="contact-input" placeholder="Your Email" />
             <textarea name="message" required className="contact-textarea" placeholder="Your Message"></textarea>
       
             <button type="submit" className="contact-button">Submit Form</button>
           </form>
           <span className="contact-result">{result}</span>
         </div>
       );
       
 }
 export default ContactUs;