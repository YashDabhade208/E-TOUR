package com.example.model;

import jakarta.persistence.*;

@Entity
public class Booking 
{
	@Id
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
	
	
}
