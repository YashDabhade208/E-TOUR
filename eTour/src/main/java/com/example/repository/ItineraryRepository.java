package com.example.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.model.Itinerary;

public interface ItineraryRepository extends JpaRepository<Itinerary, Integer> {
    List<Itinerary> findByTourId(Integer tourId);
}
