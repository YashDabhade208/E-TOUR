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

	    public List<Cost> getAllCostings() {
	        return costRepository.findAll();
	    }

	    public Optional<Cost> getCostingById(Integer id) {
	        return costRepository.findById(id);
	    }

	    public Cost createCost(Cost cost) {
	        return costRepository.save(cost);
	    }

	    public Cost updateCost(Integer id, Cost cost) {
	        if (costRepository.existsById(id)) {
	            cost.setCost_id(id);
	            return costRepository.save(cost);
	        }
	        return null;
	    }

	    public void deleteCost(Integer id) {
	        costRepository.deleteById(id);
	    }
}
