package com.example.model;

import jakarta.persistence.*;

@Entity
public class Paasenger 
{
	@Id
	private Integer passenger_id;
	
	@ManyToOne
    @JoinColumn(nullable = false)
	private Booking booking_id;
	private String passenger_name;
	private String passenger_dob;
	private String passenger_type;
	private Integer passenger_amount;
}
