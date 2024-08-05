package com.example.model;



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
    @JoinColumn( name="catmaster_id",nullable = false)
	private Category catmaster_id;
	private Integer cost;
	private Integer single_person_cost;
	private Integer extra_person_cost;
	private Integer child_with_bed_cost;
	private Integer child_without_bed_cost;
	private Integer validfrom;
	private Integer validto;
	public Integer getCost_id() {
		return cost_id;
	}
	public void setCost_id(Integer cost_id) {
		this.cost_id = cost_id;
	}
	public Category getCatmaster_id() {
		return catmaster_id;
	}
	public void setCatmaster_id(Category catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	public Integer getCost() {
		return cost;
	}
	public void setCost(Integer cost) {
		this.cost = cost;
	}
	public Integer getSingle_person_cost() {
		return single_person_cost;
	}
	public void setSingle_person_cost(Integer single_person_cost) {
		this.single_person_cost = single_person_cost;
	}
	public Integer getExtra_person_cost() {
		return extra_person_cost;
	}
	public void setExtra_person_cost(Integer extra_person_cost) {
		this.extra_person_cost = extra_person_cost;
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
	public Integer getValidfrom() {
		return validfrom;
	}
	public void setValidfrom(Integer validfrom) {
		this.validfrom = validfrom;
	}
	public Integer getValidto() {
		return validto;
	}
	public void setValidto(Integer validto) {
		this.validto = validto;
	}


}
