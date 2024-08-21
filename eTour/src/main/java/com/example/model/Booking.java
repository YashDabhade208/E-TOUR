package com.example.model;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonManagedReference;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;

@Entity
public class Booking {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private String firstname;
    private String lastname;
    private String mobileno;
    private String email;
    private String adhaarno;
    private String address;
    private String city;
    private String state;
    private String country;
    private String pincode;
    private Integer numberOfPassenger;
    private Integer numberOfChildWithBed;
    private Integer numberOfChildWithoutBed;
    private String bookingDate;

    @OneToMany(mappedBy = "booking", cascade = CascadeType.ALL, orphanRemoval = true)
    @JsonIgnore
    private List<Passenger> passengers;

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getFirstname() {
		return firstname;
	}

	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}

	public String getLastname() {
		return lastname;
	}

	public void setLastname(String lastname) {
		this.lastname = lastname;
	}

	public String getMobileno() {
		return mobileno;
	}

	public void setMobileno(String mobileno) {
		this.mobileno = mobileno;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getAdhaarno() {
		return adhaarno;
	}

	public void setAdhaarno(String adhaarno) {
		this.adhaarno = adhaarno;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getState() {
		return state;
	}

	public void setState(String state) {
		this.state = state;
	}

	public String getCountry() {
		return country;
	}

	public void setCountry(String country) {
		this.country = country;
	}

	public String getPincode() {
		return pincode;
	}

	public void setPincode(String pincode) {
		this.pincode = pincode;
	}

	public Integer getNumberOfPassenger() {
		return numberOfPassenger;
	}

	public void setNumberOfPassenger(Integer numberOfPassenger) {
		this.numberOfPassenger = numberOfPassenger;
	}

	public Integer getNumberOfChildWithBed() {
		return numberOfChildWithBed;
	}

	public void setNumberOfChildWithBed(Integer numberOfChildWithBed) {
		this.numberOfChildWithBed = numberOfChildWithBed;
	}

	public Integer getNumberOfChildWithoutBed() {
		return numberOfChildWithoutBed;
	}

	public void setNumberOfChildWithoutBed(Integer numberOfChildWithoutBed) {
		this.numberOfChildWithoutBed = numberOfChildWithoutBed;
	}

	public String getBookingDate() {
		return bookingDate;
	}

	public void setBookingDate(String bookingDate) {
		this.bookingDate = bookingDate;
	}

	public List<Passenger> getPassengers() {
		return passengers;
	}

	public void setPassengers(List<Passenger> passengers) {
		this.passengers = passengers;
	}

    
}