package com.example.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;

@Entity
public class Booking {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer booking_id;

	@ManyToOne
	@JoinColumn(name = "customer_id")
	private Customer customer_id;

	@ManyToOne
	@JoinColumn(name = "subcategory_id")
	private Tour subcategory_id;

	private String firstname;
	private String lastname;
	private Integer age;
	private String mobileno;
	private Integer numberofpassenger;
	private String gender;
	private String dateofbirth;
	private String email;
	private String adhaarno;
	private String adress;
	private String city;
	private String state;
	private String country;
	private String pincode;
	private Integer numberofchild;
	private Integer numberofchildwithbed;
	private Integer numberofchildwithoutbed;
	private String bookingdate;

	public Integer getBookingId() {
		return booking_id;
	}

	public void setBookingId(Integer bookingId) {
		this.booking_id = bookingId;
	}

	public Customer getCustomer_id() {
		return customer_id;
	}

	public void setCustomer_id(Customer customer_id) {
		this.customer_id = customer_id;
	}

	public Tour getSubcategory_id() {
		return subcategory_id;
	}

	public void setSubcategory_id(Tour subcategory_id) {
		this.subcategory_id = subcategory_id;
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

	public Integer getAge() {
		return age;
	}

	public void setAge(Integer age) {
		this.age = age;
	}

	public String getMobileno() {
		return mobileno;
	}

	public void setMobileno(String mobileno) {
		this.mobileno = mobileno;
	}

	public Integer getNumberofpassenger() {
		return numberofpassenger;
	}

	public void setNumberofpassenger(Integer numberofpassenger) {
		this.numberofpassenger = numberofpassenger;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public String getDateofbirth() {
		return dateofbirth;
	}

	public void setDateofbirth(String dateofbirth) {
		this.dateofbirth = dateofbirth;
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

	public String getAdress() {
		return adress;
	}

	public void setAdress(String adress) {
		this.adress = adress;
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

	public Integer getNumberofchild() {
		return numberofchild;
	}

	public void setNumberofchild(Integer numberofchild) {
		this.numberofchild = numberofchild;
	}

	public Integer getNumberofchildwithbed() {
		return numberofchildwithbed;
	}

	public void setNumberofchildwithbed(Integer numberofchildwithbed) {
		this.numberofchildwithbed = numberofchildwithbed;
	}

	public Integer getNumberofchildwithoutbed() {
		return numberofchildwithoutbed;
	}

	public void setNumberofchildwithoutbed(Integer numberofchildwithoutbed) {
		this.numberofchildwithoutbed = numberofchildwithoutbed;
	}

	public String getBookingdate() {
		return bookingdate;
	}

	public void setBookingdate(String bookingdate) {
		this.bookingdate = bookingdate;
	}

}
