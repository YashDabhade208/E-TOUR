package com.example.model;

import jakarta.persistence.*;

@Entity
public class Booking 
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer booking_id;
	private Integer booking_date;
	@ManyToOne
    @JoinColumn( name="customer_id",nullable = false)
	private Customer customer_id;
	@ManyToOne
    @JoinColumn( name="tour_id",nullable = false)
	private Tour tour_id;
	private Integer no_of_passenger;
	private Integer tour_amount;
	private Integer tax;
	private Integer total_amount;
	public Integer getBooking_id() {
		return booking_id;
	}
	public void setBooking_id(Integer booking_id) {
		this.booking_id = booking_id;
	}
	public Integer getBooking_date() {
		return booking_date;
	}
	public void setBooking_date(Integer booking_date) {
		this.booking_date = booking_date;
	}
	public Customer getCustomer_id() {
		return customer_id;
	}
	public void setCustomer_id(Customer customer_id) {
		this.customer_id = customer_id;
	}
	public Tour getTour_id() {
		return tour_id;
	}
	public void setTour_id(Tour tour_id) {
		this.tour_id = tour_id;
	}
	public Integer getNo_of_passenger() {
		return no_of_passenger;
	}
	public void setNo_of_passenger(Integer no_of_passenger) {
		this.no_of_passenger = no_of_passenger;
	}
	public Integer getTour_amount() {
		return tour_amount;
	}
	public void setTour_amount(Integer tour_amount) {
		this.tour_amount = tour_amount;
	}
	public Integer getTax() {
		return tax;
	}
	public void setTax(Integer tax) {
		this.tax = tax;
	}
	public Integer getTotal_amount() {
		return total_amount;
	}
	public void setTotal_amount(Integer total_amount) {
		this.total_amount = total_amount;
	}
	
	
	
	
}
