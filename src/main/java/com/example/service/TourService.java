package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Tour;
import com.example.repository.TourRepository;


public interface TourService {
    

    public List<Tour> getAllTours();
    public Tour getTourById(Integer id);
	public Tour createTour(Tour tour) ;
}

