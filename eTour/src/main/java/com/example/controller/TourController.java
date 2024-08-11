package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Tour;

import com.example.repository.TourRepository;

@RestController
@CrossOrigin("*")
@RequestMapping("/api/tours")
public class TourController {

    @Autowired
    private TourRepository tourRepository;

  

    @GetMapping
    public List<Tour> getAllTours() {
        return tourRepository.findAll();
    }
    
    @GetMapping ("/{id}")
    public ResponseEntity<Optional<Tour>> getTourById(@PathVariable Integer id) {
        Optional<Tour> tour = tourRepository.findById(id);
        return ResponseEntity.ok(tour);
}
    @PostMapping
    public Tour createTour(@RequestBody Tour tour) {
        return tourRepository.save(tour);
    }
}
