package com.example.service;

import com.example.model.Cost;
import com.example.repository.CostRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CostServiceImpl implements CostService {

    @Autowired
    private CostRepository costRepository;

    @Override
    public Cost saveCost(Cost cost) {
        return costRepository.save(cost);
    }

    @Override
    public Cost updateCost(Cost cost) {
        return costRepository.save(cost);
    }

    @Override
    public void deleteCost(Integer costId) {
        costRepository.deleteById(costId);
    }

    @Override
    public Cost getCostById(Integer costId) {
        Optional<Cost> optionalCost = costRepository.findById(costId);
        return optionalCost.orElse(null);
    }

    @Override
    public List<Cost> getAllCosts() {
        return costRepository.findAll();
    }
}
