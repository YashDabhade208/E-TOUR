package com.example.model;

import jakarta.persistence.*;

@Entity
public class Customer
{
	@Id
	private Integer customer_id;
	
	@Column(nullable=false,length=18)
	private String customer_name;
	@Column(nullable=false)
	private Integer customer_mobileno;
	private Integer customer_alternatemobileno;
	@Column(nullable=false)
	private String customer_emailid;
	@Column(nullable=false,length=255)
	private String customer_address;
	@Column(nullable=false)
	private String customer_city;
	@Column(nullable=false)
	private String customer_state;
	@Column(nullable=false)
	private Integer customer_pincode;
	@Column(nullable=false)
	private String customer_country;
	public Integer getCustomer_id() {
		return customer_id;
	}
	public void setCustomer_id(Integer customer_id) {
		this.customer_id = customer_id;
	}
	public String getCustomer_name() {
		return customer_name;
	}
	public void setCustomer_name(String customer_name) {
		this.customer_name = customer_name;
	}
	public Integer getCustomer_mobileno() {
		return customer_mobileno;
	}
	public void setCustomer_mobileno(Integer customer_mobileno) {
		this.customer_mobileno = customer_mobileno;
	}
	public Integer getCustomer_alternatemobileno() {
		return customer_alternatemobileno;
	}
	public void setCustomer_alternatemobileno(Integer customer_alternatemobileno) {
		this.customer_alternatemobileno = customer_alternatemobileno;
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
	public String getCustomer_country() {
		return customer_country;
	}
	public void setCustomer_country(String customer_country) {
		this.customer_country = customer_country;
	}
	
	
	


}
