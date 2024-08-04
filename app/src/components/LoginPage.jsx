import React from "react";
import {
   MDBBtn,
   MDBContainer,
   MDBRow,
   MDBCol,
   MDBIcon,
   MDBInput,
} from "mdb-react-ui-kit";

import { useState } from "react";
import { useLocation, useNavigate } from "react-router-dom";
import "./LoginPage.css";
import axios from "axios";

function Login() {
   const [email, setEmail] = useState("");
   const [password, setPassword] = useState("");
   const [error, setError] = useState("");
   const navigate = useNavigate();
   const location = useLocation();
   const { login, packageid, customerIdSetter } = useSelectedOptions();
   const logged = location.state;

   const handleSubmit = async (e) => {
      e.preventDefault();
      if (!email || !password) {
         setError("Please enter both email and password.");
         return;
      }
      try {
         const response = await axios.get(
            `http://localhost:8080/api/register/${email}/${password}`
         );
         if (!response.ok) {
            throw new Error("Invalid email or password.");
         }
         const result = await response.json();
         const token = result.token;
         if (token) {
            login(result.registration);
            localStorage.setItem("token", token);
            if (logged) {
               navigate("/pass", { state: packageid });
            } else {
               navigate("/");
            }
         } else {
            setError("Invalid Details");
         }
         console.log(result.registration.customer_id);
         customerIdSetter(result.registration.customer_id);
      } catch (error) {
         setError("Invalid Details");
      }
   };
   return (
      <MDBContainer fluid style={{ width: "100%", marginTop: "10px", border: "3px solid black" }}>
         <MDBRow style={{ display: "flex", flexDirection: "row" }}>
            <MDBCol sm="7" style={{ margin: "15px 10px 75px" }}>
               <div className="d-flex flex-row ps-5 pt-5">
                  <MDBIcon>
                     {" "}
                     <img
                        src="https://the7tours.net/wp-content/uploads/2023/07/7-tours-logo-1024x453.png"
                        alt=""
                        style={{ width: "150px", height: "auto", marginRight: "10px" }}
                     />
                  </MDBIcon>
                  {/* <span className="h1 fw-bold mb-0">7 Tours</span> */}
               </div>

               <div className="d-flex flex-column justify-content-center h-custom-2 w-75 pt-4">
                  <h3
                     className="fw-normal mb-3 ps-5 pb-3"
                     style={{ letterSpacing: "1px" }}
                  >
                     Log in
                  </h3>

                  <MDBInput
                     wrapperClass="mb-4 mx-5 w-100"
                     label="Email address"
                     id="formControlL"
                     type="email"
                     size="lg"
                     name="email"
                     value={email}
                     onChange={(e) => setEmail(e.target.value)}
                  />
                  <MDBInput
                     wrapperClass="mb-4 mx-5 w-100"
                     label="Password"
                     id="formControlLg"
                     type="password"
                     size="lg"
                     name="password"
                     value={password}
                     onChange={(e) => setPassword(e.target.value)}
                  />

                  {error && <div className="error-message">{error}</div>}
                  <MDBBtn
                     className="mb-4 px-5 mx-5 w-100"
                     color="info"
                     size="lg"
                     onClick={handleSubmit}
                  >
                     Login
                  </MDBBtn>
                  {/* <p className="small mb-5 pb-lg-3 ms-5">
              <a class="text-muted" href="#!">
                Forgot password?
              </a>
            </p> */}
                  <p className="ms-5">
                     Don't have an account?{" "}
                     <a href="/register" className="link-info">
                        Register here
                     </a>
                  </p>
               </div>
            </MDBCol>

            <MDBCol
               sm="4"
               className="d-none d-sm-block px-0"

            >
               <img
                  src="https://delhitourism.gov.in/dttdc/images/About_Img.jpg"
                  alt="Login "
                  className="w-100"
                  style={{ objectFit: "contain", objectPosition: "right", margin: "15px 0 15px", height: "30vw" }}
               />
            </MDBCol>
         </MDBRow>
      </MDBContainer>
   );
}

export default Login;
