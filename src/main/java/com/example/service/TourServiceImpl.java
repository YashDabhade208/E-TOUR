package com.example.service;

import java.util.List;
import java.util.NoSuchElementException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Tour;
import com.example.repository.CategoryRepository;
import com.example.repository.TourRepository;

@Service
public class TourServiceImpl implements TourService {

    @Autowired
    private TourRepository tourRepository;

    @Autowired
    private CategoryRepository categoryRepository;

    public List<Tour> getAllTours() {
        return tourRepository.findAll();
    }

    

    public Tour createTour(Tour tour) {
        return tourRepository.save(tour);
    }

    public Tour getTourById(Integer id) {
        return tourRepository.findById(id)
            .orElseThrow(() -> new NoSuchElementException("Tour not found with id " + id));
    }
}

