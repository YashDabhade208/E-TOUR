import React from 'react'
import {
   MDBFooter,
   MDBContainer,
   MDBCol,
   MDBRow,
   MDBRipple,
} from "mdb-react-ui-kit";

const Footer = () => {
   return (
      <MDBFooter
         className="text-center text-white"
         style={{ backgroundColor: "lightgrey" }}
      >
         <MDBContainer className="p-4">
            <section className="">
               <MDBRow >
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0" >
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                        style={{ width: "10vw" }}
                     >
                        <img
                           src="https://egov.eletsonline.com/wp-content/uploads/2020/01/Kerala-will-be-know-as-365-Days-tourism-destination-1.jpg"
                           className="w-100"
                           alt=""
                           style={{ height: "85px"}}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0">
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                     >
                        <img
                           src="https://www.hotelierindia.com/wp-content/uploads/cloud/2023/05/12/image-14.png"
                           className="w-100"
                           alt=""
                           style={{ height: "85px" }}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0">
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                     >
                        <img
                           src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgeYXgeMBA5QgK2bm_Xoi2kEL2k6nwQv0G83ftm7NMYrdXvsdCqTE1IfmNP4RJVShemeY&usqp=CAU"
                           className="w-100"
                           alt=""
                           style={{ height: "85px" }}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0">
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                     >
                        <img
                           src="https://visitturkey.in/wp-content/uploads/2024/08/yerkopru-waterfall-mersin.webp"
                           className="w-100"
                           alt=""
                           style={{ height: "85px" }}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0">
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                     >
                        <img
                           src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcSG3n59kt0ue83QVseRGOf2rb-jN4K4A--A&s"
                           className="w-100"
                           alt=""
                           style={{height:"85px"}}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
                  <MDBCol lg="2" md="12" className="mb-4 mb-md-0">
                     <MDBRipple
                        rippleColor="light"
                        className="bg-image hover-overlay shadow-1-strong rounded"
                     >
                        <img
                           src="https://mdbcdn.b-cdn.net/img/new/fluid/city/116.webp"
                           className="w-100"
                           alt=""
                           style={{ height: "85px" }}
                        />
                        <a href="#!">
                           <div
                              className="mask"
                              style={{ backgroundColor: "rgba(251, 251, 251, 0.2)" }}
                           ></div>
                        </a>
                     </MDBRipple>
                  </MDBCol>
               </MDBRow>
            </section>
         </MDBContainer>
         <footer style={{ padding: '20px', backgroundColor: '#333', color: '#fff', textAlign: 'center' }}>
            <div style={{ marginBottom: '10px' }}>
               <a href="#privacy" style={{ color: '#fff', textDecoration: 'none', marginRight: '10px' }}>Privacy Policy</a>
               <a href="#terms" style={{ color: '#fff', textDecoration: 'none', marginLeft: '10px' }}>Terms of Service</a>
            </div>
            <div>
               <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-facebook-f"></i></a>
               <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-twitter"></i></a>
               <a href="#" style={{ color: '#fff', margin: '0 10px' }}><i className="fab fa-instagram"></i></a>
            </div>
         </footer>
      </MDBFooter>
   )
}

export default Footer