package com.example.service;

import com.example.model.Cost;
import com.example.repository.CostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CostService {

    @Autowired
    private CostRepository costRepository;

    public List<Cost> getAllCosts() {
        return costRepository.findAll();
    }

    public Optional<Cost> getCostByTourId(Integer tourId) {
        return costRepository.findByTourId(tourId);
    }


    public Cost createOrUpdateCost(Cost cost) {
        return costRepository.save(cost);
    }

    public void deleteCost(Integer id) {
        costRepository.deleteById(id);
    }
}
