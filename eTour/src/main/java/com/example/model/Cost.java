package com.example.model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "cost")
public class Cost {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "cost_id")
    private Integer id;

    @ManyToOne
    @JoinColumn(name = "tour_id", nullable = false)
    private Tour tour;

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

    public Tour getTour() {
        return tour;
    }

    public void setTour(Tour tour) {
        this.tour = tour;
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
