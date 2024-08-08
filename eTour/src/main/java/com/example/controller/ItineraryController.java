package com.example.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Itinerary;
import com.example.service.ItineraryService;

@RestController
@RequestMapping("/api/itineraries")
@CrossOrigin("*")
public class ItineraryController {
    @Autowired
    private ItineraryService itineraryService;

    @GetMapping
    public List<Itinerary> getAllItineraries() {
        return itineraryService.getAllItineraries();
    }

    @GetMapping("/{id}")
    public Itinerary getItineraryById(@PathVariable Integer id) {
        return itineraryService.getItineraryById(id);
    }

    @GetMapping("/tour/{tourId}")
    public List<Itinerary> getItinerariesByTourId(@PathVariable Integer tourId) {
        return itineraryService.getItinerariesByTourId(tourId);
    }

    @PostMapping
    public Itinerary createItinerary(@RequestBody Itinerary itinerary) {
        return itineraryService.createItinerary(itinerary);
    }

    @PutMapping("/{id}")
    public Itinerary updateItinerary(@PathVariable Integer id, @RequestBody Itinerary itinerary) {
        return itineraryService.updateItinerary(id, itinerary);
    }

    @DeleteMapping("/{id}")
    public void deleteItinerary(@PathVariable Integer id) {
        itineraryService.deleteItinerary(id);
    }
}
