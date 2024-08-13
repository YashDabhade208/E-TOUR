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
import logo from "../components/Assets/logo.png";

function LoginPage() {
   const [customer_emailid, setEmail] = useState("");
   const [customer_password, setPassword] = useState("");
   const [error, setError] = useState("");
   const navigate = useNavigate();
   const location = useLocation();
   // const { login, packageid, customerIdSetter } = useSelectedOptions();
   const logged = location.state;

   const handleSubmit = async (e) => {
      e.preventDefault();
      if (!customer_emailid || !customer_password) {
          setError("Please enter both email and password.");
          return;
      }
      try {
          const response = await fetch(
              "http://localhost:8080/api/customers/login",
              {
                  method: "POST",
                  headers: {
                      "Content-Type": "application/json",
                  },
                  body: JSON.stringify({
                      customer_emailid,
                      customer_password,
                  }),
              }
          );
          if (!response.ok) {
              throw new Error("Invalid email or password.");
          }
          const result = await response.json();
          const token = result.token;
          if (token) {
              alert("Login Sucessfully!!!")
              localStorage.setItem("token", token);
              navigate("/");
          } else {
              setError("Invalid Details");
          }
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
                        src={logo}
                        alt=""
                        style={{ width: "75px", height: "auto", marginRight: "10px" }}
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
                     name="customer_emailid"
                     value={customer_emailid}
                     onChange={(e) => setEmail(e.target.value)}
                  />
                  <MDBInput
                     wrapperClass="mb-4 mx-5 w-100"
                     label="Password"
                     id="formControlLg"
                     type="password"
                     size="lg"
                     name="customer_password"
                     value={customer_password}
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
                     <a href="/register" class="link-info">
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
                  src="https://t4.ftcdn.net/jpg/01/78/13/49/360_F_178134998_7VBDhYkoLBco8hqDX9SmQBsP0PPhZNBW.jpg"
                  alt="Login "
                  className="w-100"
                  style={{ objectFit: "contain", objectPosition: "right", margin: "15px 0 15px", height: "30vw" }}
               />
            </MDBCol>
         </MDBRow>
      </MDBContainer>
   );
}

export default LoginPage;
