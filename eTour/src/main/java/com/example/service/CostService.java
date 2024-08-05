package com.example.service;

import com.example.model.Cost;
import java.util.List;

public interface CostService {
    Cost saveCost(Cost cost);
    Cost updateCost(Cost cost);
    void deleteCost(Integer costId);
    Cost getCostById(Integer costId);
    List<Cost> getAllCosts();
}
