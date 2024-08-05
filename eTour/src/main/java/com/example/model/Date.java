package com.example.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
@Entity
public class Date
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer departure_id;
	@ManyToOne
    @JoinColumn( name="catmaster_id",nullable = false)
	private Category catmaster_id;
	private Integer departure_Integer;
	private Integer end_Integer;
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
	public Integer getDeparture_Integer() {
		return departure_Integer;
	}
	public void setDeparture_Integer(Integer departure_Integer) {
		this.departure_Integer = departure_Integer;
	}
	public Integer getEnd_Integer() {
		return end_Integer;
	}
	public void setEnd_Integer(Integer end_Integer) {
		this.end_Integer = end_Integer;
	}
	public Integer getTotal_days() {
		return total_days;
	}
	public void setTotal_days(Integer total_days) {
		this.total_days = total_days;
	}
}
