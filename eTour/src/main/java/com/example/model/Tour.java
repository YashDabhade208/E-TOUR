package com.example.model;

import jakarta.persistence.*;

@Entity
public class Tour 
{
	@Id
	private Integer tour_id;
	@ManyToOne
    @JoinColumn( name="departure_id",nullable = false)
	private Date departure_id; 
	@ManyToOne
    @JoinColumn( name="catmaster_id",nullable = false)
	private Category catmaster_id;
	public Integer getTour_id() {
		return tour_id;
	}
	public void setTour_id(Integer tour_id) {
		this.tour_id = tour_id;
	}
	public Date getDeparture_id() {
		return departure_id;
	}
	public void setDeparture_id(Date departure_id) {
		this.departure_id = departure_id;
	}
	public Category getCatmaster_id() {
		return catmaster_id;
	}
	public void setCatmaster_id(Category catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	
	
}
