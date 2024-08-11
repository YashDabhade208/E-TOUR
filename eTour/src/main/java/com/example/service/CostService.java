package com.example.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Cost;
import com.example.repository.CostRepository;

@Service
public class CostService {

    @Autowired
    private CostRepository costRepository;

    public Cost saveCost(Cost cost) {
        return costRepository.save(cost);
    }

    public Cost getCostById(Integer id) {
        return costRepository.findById(id).orElse(null);
    }

    public Cost updateCost(Integer id, Cost costDetails) {
        return costRepository.findById(id).map(cost -> {
            cost.setSinglePersonCost(costDetails.getSinglePersonCost());
            cost.setChildWithBedCost(costDetails.getChildWithBedCost());
            cost.setChildWithoutBedCost(costDetails.getChildWithoutBedCost());
            return costRepository.save(cost);
        }).orElseThrow(() -> new RuntimeException("Cost not found with id " + id));
    }

    public void deleteCost(Integer id) {
        costRepository.deleteById(id);
    }
}
