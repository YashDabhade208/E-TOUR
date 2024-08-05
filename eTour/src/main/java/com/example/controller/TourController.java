package com.example.controller;

import com.example.model.Tour;
import com.example.service.TourService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/tours")
public class TourController {

    @Autowired
    private TourService tourService;

    @PostMapping
    public ResponseEntity<Tour> createTour(@RequestBody Tour tour) {
        Tour savedTour = tourService.saveTour(tour);
        return ResponseEntity.ok(savedTour);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Tour> updateTour(@PathVariable Integer id, @RequestBody Tour tour) {
        tour.setTour_id(id);
        Tour updatedTour = tourService.updateTour(tour);
        return ResponseEntity.ok(updatedTour);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteTour(@PathVariable Integer id) {
        tourService.deleteTour(id);
        return ResponseEntity.noContent().build();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Tour> getTourById(@PathVariable Integer id) {
        Tour tour = tourService.getTourById(id);
        return ResponseEntity.ok(tour);
    }

    @GetMapping
    public ResponseEntity<List<Tour>> getAllTours() {
        List<Tour> tours = tourService.getAllTours();
        return ResponseEntity.ok(tours);
    }
}
