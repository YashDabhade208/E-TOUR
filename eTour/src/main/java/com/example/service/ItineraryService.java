package com.example.service;

import java.util.List;



import com.example.model.Itinerary;



public interface ItineraryService {
  
    public List<Itinerary> getAllItineraries() ;

    public Itinerary getItineraryById(Integer id);

    public List<Itinerary> getItinerariesByTourId(Integer tourId);

    public Itinerary createItinerary(Itinerary itinerary);

    public Itinerary updateItinerary(Integer id, Itinerary itinerary);

    public void deleteItinerary(Integer id) ;
}
