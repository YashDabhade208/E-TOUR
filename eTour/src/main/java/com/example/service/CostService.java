package com.example.service;

import com.example.model.Cost;
import java.util.List;
import java.util.Optional;

public interface CostService {
	public List<Cost> getAllCostings();
	public Optional<Cost> getCostingById(Integer id);
	 public Cost updateCost(Integer id, Cost cost) ;
	 public void deleteCost(Integer id);
	public Cost createCost(Cost cost);
	 
}
