import React, { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import 'bootstrap/dist/css/bootstrap.min.css';
import logo from "../components/Assets/logo.png";
import { NavLink } from 'react-router-dom';
import './Navbarr.css';

function Navbarr() {
  const [searchTerm, setSearchTerm] = useState("");
  const [searchResults, setSearchResults] = useState([]);

  const handleInputChange = (e) => {
    setSearchTerm(e.target.value);
  };

  const handleSearch = async (e) => {
    e.preventDefault();
    
    if (!localStorage.getItem('toursData')) {
      try {
        const response = await fetch(`http://localhost:8080/api/tours`);
        if (!response.ok) {
          throw new Error('Failed to fetch search results');
        }
        const data = await response.json();
        localStorage.setItem('toursData', JSON.stringify(data));
      } catch (error) {
        console.error('Error during search:', error);
        return;
      }
    }

    const storedData = JSON.parse(localStorage.getItem('toursData'));

    const filteredResults = storedData.filter(tour => 
      tour.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
      tour.destination.toLowerCase().includes(searchTerm.toLowerCase())
    );

    setSearchResults(filteredResults);
  };

  return (
    <>
      <Navbar expand="lg" className="navbar-bg">
        <Container fluid>
          <Navbar.Brand><img src={logo} alt="" style={{ width: "50px" }} /></Navbar.Brand>
          <Navbar.Toggle aria-controls="navbarScroll" />
          <Navbar.Collapse id="navbarScroll">
            <Nav
              className="me-auto my-2 my-lg-0"
              style={{ maxHeight: '100px' }}
              navbarScroll
            >
              <Nav.Link>
                <NavLink to="/">Home</NavLink>
              </Nav.Link>
              <Nav.Link>
                <NavLink to="/Login">Login</NavLink>
              </Nav.Link>
              <NavDropdown title="Tours" id="navbarScrollingDropdown">
                <NavDropdown.Item>
                  <NavLink to="/">Home</NavLink>
                </NavDropdown.Item>
                <NavDropdown.Divider />
                <NavDropdown.Item>
                  <NavLink to="/Domestic">Domestic Tours</NavLink>
                </NavDropdown.Item>
                <NavDropdown.Item>
                  <NavLink to="/International">International Tours</NavLink>
                </NavDropdown.Item>
                <NavDropdown.Item>
                  <NavLink to="/Eventbased">Eventbased Tours</NavLink>
                </NavDropdown.Item>
              </NavDropdown>

              <Nav.Link>
                <NavLink to="Packages">Packages</NavLink>
              </Nav.Link>
              <Nav.Link>
                <NavLink to="/ContactUs">Contact Us</NavLink>
              </Nav.Link>
              <Nav.Link>
                <NavLink to="/AboutUs">About Us</NavLink>
              </Nav.Link>
            </Nav>
            <Form className="d-flex position-relative" onSubmit={handleSearch}>
              <Form.Control
                type="search"
                placeholder="Search"
                value={searchTerm}
                onChange={handleInputChange}
                className="me-2"
                aria-label="Search"
              />
              <Button style={{ backgroundColor: 'red', color: 'black' }} type="submit">
                Search
              </Button>

              {searchResults.length > 0 && (
                <div className="dropdown-menu show w-100" style={{ top: '100%' }}>
                  {searchResults.map((tour) => (
                    <NavLink
                      key={tour.id}
                      to={`/tourdetails/${tour.id}`}
                      className="dropdown-item"
                    >
                      {tour.name} - {tour.destination}
                    </NavLink>
                  ))}
                </div>
              )}
            </Form>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </>
  );
}

export default Navbarr;
