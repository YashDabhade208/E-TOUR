package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.PathVariable;

import com.example.model.Tour;
import com.example.repository.TourRepository;


public interface TourService {
    
    public List<Tour> getAllTours();
    public Tour getTourById(Integer id);
	public Tour createTour(Tour tour) ;
}

