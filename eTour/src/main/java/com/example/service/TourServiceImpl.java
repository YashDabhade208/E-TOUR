package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Itinerary;
import com.example.model.Tour;
import com.example.repository.TourRepository;

@Service
public class TourServiceImpl implements TourService{
    @Autowired
    private TourRepository tourRepository;

    public List<Tour> getAllTours() {
        return tourRepository.findAll();
    }

    public Tour getTourById(Integer id) {
        return tourRepository.findById(id).orElseThrow();
    }
    public Tour createTour(Tour tour) {
        for (Itinerary itinerary : tour.getItineraries()) {
            itinerary.setTour(tour);
        }
        return tourRepository.save(tour);
    }
}

