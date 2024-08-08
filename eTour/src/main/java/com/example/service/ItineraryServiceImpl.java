package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Itinerary;
import com.example.repository.ItineraryRepository;

@Service
public class ItineraryServiceImpl implements ItineraryService{
    @Autowired
    private ItineraryRepository itineraryRepository;

    public List<Itinerary> getAllItineraries() {
        return itineraryRepository.findAll();
    }

    public Itinerary getItineraryById(Integer id) {
        return itineraryRepository.findById(id).orElseThrow();
    }

    public List<Itinerary> getItinerariesByTourId(Integer tourId) {
        return itineraryRepository.findByTourId(tourId);
    }
public Itinerary createItinerary(Itinerary itinerary) {
        return itineraryRepository.save(itinerary);
    }

    public Itinerary updateItinerary(Integer id, Itinerary itinerary) {
        Itinerary existingItinerary = getItineraryById(id);
        existingItinerary.setDescription(itinerary.getDescription());
        existingItinerary.setDate(itinerary.getDate());
        return itineraryRepository.save(existingItinerary);
    }

    public void deleteItinerary(Integer id) {
        itineraryRepository.deleteById(id);
    }
}
