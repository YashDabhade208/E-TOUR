package com.example.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Itinerary;
import com.example.model.Tour;
import com.example.service.ItineraryService;
import com.example.service.TourService;

@RestController
@RequestMapping("/api")
public class TourController {
    @Autowired
    private TourService tourService;

    @Autowired
    private ItineraryService itineraryService;

    @GetMapping("/tours")
    public List<Tour> getAllTours() {
        return tourService.getAllTours();
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

