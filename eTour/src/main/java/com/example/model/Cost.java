package com.example.model;

import jakarta.persistence.*;

@Entity
@Table(name = "cost")
public class Cost {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "cost_id")
    private Integer id;

    @Column(name = "single_person_cost")
    private Integer singlePersonCost;

    @Column(name = "child_with_bed_cost")
    private Integer childWithBedCost;

    @Column(name = "child_without_bed_cost")
    private Integer childWithoutBedCost;

    // Getters and Setters
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Integer getSinglePersonCost() {
        return singlePersonCost;
    }

    public void setSinglePersonCost(Integer singlePersonCost) {
        this.singlePersonCost = singlePersonCost;
    }

    public Integer getChildWithBedCost() {
        return childWithBedCost;
    }

    public void setChildWithBedCost(Integer childWithBedCost) {
        this.childWithBedCost = childWithBedCost;
    }

    public Integer getChildWithoutBedCost() {
        return childWithoutBedCost;
    }

    public void setChildWithoutBedCost(Integer childWithoutBedCost) {
        this.childWithoutBedCost = childWithoutBedCost;
    }
}
