package com.example.model;

import jakarta.persistence.*;

@Entity
public class Passenger 
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer passenger_id;
	
	@ManyToOne
    @JoinColumn(nullable = false)
	private Booking booking_id;
	private String passenger_name;
	private String passenger_dob;
	private String passenger_type;
	private Integer passenger_amount;
	public Integer getPassenger_id() {
		return passenger_id;
	}
	public void setPassenger_id(Integer passenger_id) {
		this.passenger_id = passenger_id;
	}
	public Booking getBooking_id() {
		return booking_id;
	}
	public void setBooking_id(Booking booking_id) {
		this.booking_id = booking_id;
	}
	public String getPassenger_name() {
		return passenger_name;
	}
	public void setPassenger_name(String passenger_name) {
		this.passenger_name = passenger_name;
	}
	public String getPassenger_dob() {
		return passenger_dob;
	}
	public void setPassenger_dob(String passenger_dob) {
		this.passenger_dob = passenger_dob;
	}
	public String getPassenger_type() {
		return passenger_type;
	}
	public void setPassenger_type(String passenger_type) {
		this.passenger_type = passenger_type;
	}
	public Integer getPassenger_amount() {
		return passenger_amount;
	}
	public void setPassenger_amount(Integer passenger_amount) {
		this.passenger_amount = passenger_amount;
	}
	
}
