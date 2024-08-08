package com.example.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Itinerary;
import com.example.model.Tour;
import com.example.service.ItineraryService;
import com.example.service.TourService;

@RestController
@RequestMapping("/api")
@CrossOrigin("*")
public class TourController {
    @Autowired
    private TourService tourService;

    @Autowired
    private ItineraryService itineraryService;

    @GetMapping("/tours")
    public List<Tour> getAllTours() {
        return tourService.getAllTours();
    }
    @PostMapping("/createTour")
    public ResponseEntity<String> createTours(@RequestBody List<Tour> tours) {
        try {
            for (Tour tour : tours) {
                tourService.createTour(tour);
            }
            return new ResponseEntity<>("Tours created successfully", HttpStatus.CREATED);
        } catch (Exception e) {
            return new ResponseEntity<>("Error creating tours: " + e.getMessage(), HttpStatus.BAD_REQUEST);
        }
    }
    
    @GetMapping("/tours/{id}")
    public Tour getTourById(@PathVariable Integer id) {
        return tourService.getTourById(id);
    }

    @GetMapping("/tours/{id}/itineraries")
    public List<Itinerary> getItinerariesByTourId(@PathVariable Integer id) {
        return itineraryService.getItinerariesByTourId(id);
    }
}

