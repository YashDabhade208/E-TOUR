package com.example.service;

import com.example.model.Tour;
import com.example.repository.TourRepository;
import com.example.service.TourService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class TourServiceImpl implements TourService {

    @Autowired
    private TourRepository tourRepository;

    @Override
    public Tour saveTour(Tour tour) {
        return tourRepository.save(tour);
    }

    @Override
    public Tour updateTour(Tour tour) {
        return tourRepository.save(tour);
    }

    @Override
    public void deleteTour(Integer tourId) {
        tourRepository.deleteById(tourId);
    }

    @Override
    public Tour getTourById(Integer tourId) {
        Optional<Tour> optionalTour = tourRepository.findById(tourId);
        return optionalTour.orElse(null);
    }

    @Override
    public List<Tour> getAllTours() {
        return tourRepository.findAll();
    }
}
