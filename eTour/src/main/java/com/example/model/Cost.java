package com.example.model;



import com.fasterxml.jackson.annotation.JsonBackReference;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;

@Entity
public class Cost
{
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer cost_id;

    @ManyToOne
    @JoinColumn( name="tourid",nullable = false)
    @JsonBackReference
	private Tour tourid;
	private Integer single_person_cost;
	private Integer child_with_bed_cost;
	private Integer child_without_bed_cost;

	public Integer getCost_id() {
		return cost_id;
	}
	public void setCost_id(Integer cost_id) {
		this.cost_id = cost_id;
	}
	
	public Integer getSingle_person_cost() {
		return single_person_cost;
	}
	public void setSingle_person_cost(Integer single_person_cost) {
		this.single_person_cost = single_person_cost;
	}
	
	public Integer getChild_with_bed_cost() {
		return child_with_bed_cost;
	}
	public void setChild_with_bed_cost(Integer child_with_bed_cost) {
		this.child_with_bed_cost = child_with_bed_cost;
	}
	public Integer getChild_without_bed_cost() {
		return child_without_bed_cost;
	}
	public void setChild_without_bed_cost(Integer child_without_bed_cost) {
		this.child_without_bed_cost = child_without_bed_cost;
	}
	


}
