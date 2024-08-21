package com.example.controller;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
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
@CrossOrigin("*")
public class CostController {

    @Autowired
    private CostService costService;

    @PostMapping
    public ResponseEntity<Cost> createCost(@RequestBody Cost cost) {
        Cost savedCost = costService.saveCost(cost);
        return ResponseEntity.ok(savedCost);
    }

    @GetMapping("/{id}")
    public ResponseEntity<Cost> getCostById(@PathVariable Integer id) {
        Cost cost = costService.getCostById(id);
        if (cost == null) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(cost);
    }


    @PutMapping("/{id}")
    public ResponseEntity<Cost> updateCost(@PathVariable Integer id, @RequestBody Cost costDetails) {
        Cost updatedCost = costService.updateCost(id, costDetails);
        return ResponseEntity.ok(updatedCost);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteCost(@PathVariable Integer id) {
        costService.deleteCost(id);
        return ResponseEntity.noContent().build();
    }
}
