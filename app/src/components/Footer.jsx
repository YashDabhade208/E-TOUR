import React from 'react'
import {
   MDBFooter,
   MDBContainer,
   MDBCol,
   MDBRow,
   MDBRipple,
   MDBIcon
} from "mdb-react-ui-kit";

const Footer = () => {
   return (
      <MDBFooter
         className="text-center text-white"
         style={{ backgroundColor: "black" }}
      >
         <MDBContainer className="p-4">
            <section className=''>
               <MDBContainer className='text-center text-md-start mt-5'>
                  <MDBRow className='mt-1'>
                     <MDBCol md='3' lg='4' xl='3' className='mx-auto mb-4'>
                        <h6 className='text-uppercase fw-bold mb-4'>
                           <MDBIcon color='secondary' icon='gem' className='me-3' />
                           7 Tours
                        </h6>
                        <p>
                           Lorem ipsum dolor sit amet consectetur adipisicing elit. Sed aut ea magni dicta, rem a ullam sapiente ducimus facere ipsam reiciendis temporibus veniam autem maxime alias, velit labore. Nihil, rem.
                        </p>
                     </MDBCol>

                     <MDBCol md='2' lg='2' xl='2' className='mx-auto mb-4'>
                        <h6 className='text-uppercase fw-bold mb-4'>Tour Categories</h6>
                        <p>
                           <a href='#!' className='text-reset'>
                              Domestic
                           </a>
                        </p>
                        <p>
                           <a href='#!' className='text-reset'>
                              International
                           </a>
                        </p>
                        <p>
                           <a href='#!' className='text-reset'>
                              Event Based
                           </a>
                        </p>
                       
                     </MDBCol>

                     <MDBCol md='3' lg='2' xl='2' className='mx-auto mb-4'>
                        <h6 className='text-uppercase fw-bold mb-4'>Useful links</h6>
                        <p>
                           <a href='#!' className='text-reset'>
                              Pricing
                           </a>
                        </p>
                        <p>
                           <a href='#!' className='text-reset'>
                              Settings
                           </a>
                        </p>
                        <p>
                           <a href='#!' className='text-reset'>
                              Help
                           </a>
                        </p>
                     </MDBCol>

                     <MDBCol md='4' lg='3' xl='3' className='mx-auto mb-md-0 mb-4'>
                        <h6 className='text-uppercase fw-bold mb-4'>Contact</h6>
                        <p>
                           <MDBIcon color='secondary' icon='home' className='me-2' />
                           New York, NY 10012, US
                        </p>
                        <p>
                           <MDBIcon color='secondary' icon='envelope' className='me-3' />
                           info@example.com
                        </p>
                        <p>
                           <MDBIcon color='secondary' icon='phone' className='me-3' /> + 01 234 567 88
                        </p>
                        <p>
                           <MDBIcon color='secondary' icon='print' className='me-3' /> + 01 234 567 89
                        </p>
                     </MDBCol>
                     <MDBRow style={{ display: "flex", justifyContent: "center", alignItems: "center", backgroundColor: "#4d483c", height:"75px" }}>
                        <div style={{ marginTop: '5px', marginLeft:"60vw" }}>
                           <a href="#privacy" style={{ color: '#fff', textDecoration: 'none', marginRight: '10px' }}>Privacy Policy</a>
                           <a href="#terms" style={{ color: '#fff', textDecoration: 'none', marginLeft: '10px' }}>Terms of Service</a>
                        </div>
                        <div style={{marginLeft:"70vw"}}>
                           <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-facebook-f"></i></a>
                           <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-twitter"></i></a>
                           <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-instagram"></i></a>
                        </div>
                     </MDBRow>
                  </MDBRow>
                 
               </MDBContainer>
            </section>
         </MDBContainer>
         {/* <footer style={{ padding: '20px', backgroundColor: '#333', color: '#fff', textAlign: 'center' }}>
           
         </footer> */}
      </MDBFooter>
   )
}

export default Footer;
