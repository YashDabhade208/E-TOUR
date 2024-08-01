package com.example.model;

import jakarta.persistence.*;

@Entity
public class Date 
{
	@Id
	private Integer departure_id;
	@ManyToOne
    @JoinColumn( name="catmaster_id",nullable = false)
	private Category catmaster_id;
	private Date departure_date;
	private Date end_date;
	private Integer total_days;
	public Integer getDeparture_id() {
		return departure_id;
	}
	public void setDeparture_id(Integer departure_id) {
		this.departure_id = departure_id;
	}
	public Category getCatmaster_id() {
		return catmaster_id;
	}
	public void setCatmaster_id(Category catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	public Date getDeparture_date() {
		return departure_date;
	}
	public void setDeparture_date(Date departure_date) {
		this.departure_date = departure_date;
	}
	public Date getEnd_date() {
		return end_date;
	}
	public void setEnd_date(Date end_date) {
		this.end_date = end_date;
	}
	public Integer getTotal_days() {
		return total_days;
	}
	public void setTotal_days(Integer total_days) {
		this.total_days = total_days;
	}
}
