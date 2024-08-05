package com.example.service;

import com.example.model.Tour;
import java.util.List;

public interface TourService 
{
    Tour saveTour(Tour tour);
    Tour updateTour(Tour tour);
    void deleteTour(Integer tourId);
    Tour getTourById(Integer tourId);
    List<Tour> getAllTours();
}
