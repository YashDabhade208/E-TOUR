package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Cost;
import com.example.service.CostService;

@RestController
@RequestMapping("/api/costs")
public class CostController {

    @Autowired
    private CostService costService;

    @GetMapping
    public List<Cost> getAllCosts() {
        return costService.getAllCosts();
    }

    @GetMapping("/{tourId}")
    public ResponseEntity<Cost> getCostByTourId(@PathVariable Integer tourId) {
        Optional<Cost> cost = costService.getCostByTourId(tourId);
        if (cost.isPresent()) {
            return ResponseEntity.ok(cost.get());
        } else {
            return ResponseEntity.notFound().build();
        }
    }


    @PostMapping
    public ResponseEntity<Cost> createCost(@RequestBody Cost cost) {
        Cost createdCost = costService.createOrUpdateCost(cost);
        return ResponseEntity.status(HttpStatus.CREATED).body(createdCost);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Cost> updateCost(@PathVariable Integer id, @RequestBody Cost costDetails) {
        Optional<Cost> cost = costService.getCostByTourId(id);
        if (cost.isPresent()) {
            Cost existingCost = cost.get();
            existingCost.setTour(costDetails.getTour());
            existingCost.setSinglePersonCost(costDetails.getSinglePersonCost());
            existingCost.setChildWithBedCost(costDetails.getChildWithBedCost());
            existingCost.setChildWithoutBedCost(costDetails.getChildWithoutBedCost());
            final Cost updatedCost = costService.createOrUpdateCost(existingCost);
            return ResponseEntity.ok(updatedCost);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteCost(@PathVariable Integer id) {
        Optional<Cost> cost = costService.getCostByTourId(id);
        if (cost.isPresent()) {
            costService.deleteCost(id);
            return ResponseEntity.noContent().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }
}
