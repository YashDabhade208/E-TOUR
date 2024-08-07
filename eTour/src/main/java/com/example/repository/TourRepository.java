package com.example.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.model.Tour;

public interface TourRepository extends JpaRepository<Tour, Integer> {
}