package com.example.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.model.Cost;

@Repository
public interface CostRepository extends JpaRepository<Cost, Integer> {
    // You can define custom query methods here if needed
}
