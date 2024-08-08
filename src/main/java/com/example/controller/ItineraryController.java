package com.example.controller;

import java.util.NoSuchElementException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Itinerary;
import com.example.model.Tour;
import com.example.repository.ItineraryRepository;
import com.example.repository.TourRepository;

@RestController
@RequestMapping("/api/itineraries")
public class ItineraryController {

    @Autowired
    private ItineraryRepository itineraryRepository;

    @Autowired
    private TourRepository tourRepository;
    
    @GetMapping("/{id}")
    public ResponseEntity<Itinerary> getItineraryById(@PathVariable Integer id) {
        return itineraryRepository.findById(id)
            .map(itinerary -> ResponseEntity.ok(itinerary))
            .orElseThrow(() -> new NoSuchElementException("Itinerary not found with id " + id));
    }
    

    @PostMapping("/tour/{tourId}")
    public Itinerary createItinerary(@PathVariable Integer tourId, @RequestBody Itinerary itinerary) {
        Tour tour = tourRepository.findById(tourId)
            .orElseThrow(() -> new NoSuchElementException("Tour not found with id " + tourId));
        itinerary.setTour(tour);
        return itineraryRepository.save(itinerary);
    }

  
}

