package com.example.controller;

import com.example.model.Cost;
import com.example.service.CostService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/costs")
public class CostController {

    @Autowired
    private CostService costService;

    @PostMapping
    public ResponseEntity<Cost> createCost(@RequestBody Cost cost) {
        Cost savedCost = costService.saveCost(cost);
        return ResponseEntity.ok(savedCost);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Cost> updateCost(@PathVariable Integer id, @RequestBody Cost cost) {
        cost.setCost_id(id);
        Cost updatedCost = costService.updateCost(cost);
        return ResponseEntity.ok(updatedCost);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteCost(@PathVariable Integer id) {
        costService.deleteCost(id);
        return ResponseEntity.noContent().build();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Cost> getCostById(@PathVariable Integer id) {
        Cost cost = costService.getCostById(id);
        return ResponseEntity.ok(cost);
    }

    @GetMapping
    public ResponseEntity<List<Cost>> getAllCosts() {
        List<Cost> costs = costService.getAllCosts();
        return ResponseEntity.ok(costs);
    }
}
