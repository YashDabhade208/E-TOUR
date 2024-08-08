package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Itinerary;
import com.example.repository.ItineraryRepository;


public interface ItineraryService {
  
    public List<Itinerary> getAllItineraries() ;

    public Itinerary getItineraryById(Integer id);

    public List<Itinerary> getItinerariesByTourId(Integer tourId);

    public Itinerary createItinerary(Itinerary itinerary);

    public Itinerary updateItinerary(Integer id, Itinerary itinerary);

    public void deleteItinerary(Integer id) ;
}
