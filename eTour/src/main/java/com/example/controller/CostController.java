// src/main/java/com/example/controller/CostController.java

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

    @GetMapping
    public List<Cost> getAllCosts() {
        return costService.getAllCostings();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Cost> getCostById(@PathVariable Integer id) {
        return costService.getCostingById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public Cost createCost(@RequestBody Cost cost) {
        return costService.createCost(cost);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Cost> updateCost(@PathVariable Integer id, @RequestBody Cost cost) {
        Cost updatedCost = costService.updateCost(id, cost);
        if (updatedCost != null) {
            return ResponseEntity.ok(updatedCost);
        }
        return ResponseEntity.notFound().build();
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteCost(@PathVariable Integer id) {
        costService.deleteCost(id);
        return ResponseEntity.noContent().build();
    }
}
