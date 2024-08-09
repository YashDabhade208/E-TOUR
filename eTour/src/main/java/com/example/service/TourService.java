package com.example.service;

import java.util.List;


import com.example.model.Tour;



public interface TourService {
    
    public List<Tour> getAllTours();
    public Tour getTourById(Integer id);
	public Tour createTour(Tour tour) ;
}

