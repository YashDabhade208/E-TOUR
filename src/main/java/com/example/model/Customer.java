package com.example.model;



import jakarta.persistence.*;

@Entity
public class Customer
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer customer_id;
	
	private String customer_firstname;
	private String customer_lastname;
	private String customer_gender;
	private String customer_dob;
	private String customer_username;
	private String customer_password;
	
	
	private Long customer_mobileno;
	//private Long customer_alternatemobileno;
	
	private String customer_emailid;
	
	private String customer_address;
	
	private String customer_city;
	
	private String customer_state;
	
	private Integer customer_pincode;
	
	
	public Integer getCustomer_id() {
		return customer_id;
	}
	public void setCustomer_id(Integer customer_id) {
		this.customer_id = customer_id;
	}
	public String getCustomer_firstname() {
		return customer_firstname;
	}
	public void setCustomer_firstname(String customer_firstname) {
		this.customer_firstname = customer_firstname;
	}
	public String getCustomer_lastname() {
		return customer_lastname;
	}
	public void setCustomer_lastname(String customer_lastname) {
		this.customer_lastname = customer_lastname;
	}
	public String getCustomer_gender() {
		return customer_gender;
	}
	public void setCustomer_gender(String customer_gender) {
		this.customer_gender = customer_gender;
	}
	public String getCustomer_dob() {
		return customer_dob;
	}
	public void setCustomer_dob(String customer_dob) {
		this.customer_dob = customer_dob;
	}
	public String getCustomer_username() {
		return customer_username;
	}
	public void setCustomer_username(String customer_username) {
		this.customer_username = customer_username;
	}
	public String getCustomer_password() {
		return customer_password;
	}
	public void setCustomer_password(String customer_password) {
		this.customer_password = customer_password;
	}
	public Long getCustomer_mobileno() {
		return customer_mobileno;
	}
	public void setCustomer_mobileno(Long customer_mobileno) {
		this.customer_mobileno = customer_mobileno;
	}
	public String getCustomer_emailid() {
		return customer_emailid;
	}
	public void setCustomer_emailid(String customer_emailid) {
		this.customer_emailid = customer_emailid;
	}
	public String getCustomer_address() {
		return customer_address;
	}
	public void setCustomer_address(String customer_address) {
		this.customer_address = customer_address;
	}
	public String getCustomer_city() {
		return customer_city;
	}
	public void setCustomer_city(String customer_city) {
		this.customer_city = customer_city;
	}
	public String getCustomer_state() {
		return customer_state;
	}
	public void setCustomer_state(String customer_state) {
		this.customer_state = customer_state;
	}
	public Integer getCustomer_pincode() {
		return customer_pincode;
	}
	public void setCustomer_pincode(Integer customer_pincode) {
		this.customer_pincode = customer_pincode;
	}

	
	
	
	
	


}
