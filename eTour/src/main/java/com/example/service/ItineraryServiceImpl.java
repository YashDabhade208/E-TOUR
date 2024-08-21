package com.example.service;

import java.util.List;
import java.util.NoSuchElementException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Itinerary;
import com.example.model.Tour;
import com.example.repository.ItineraryRepository;
import com.example.repository.TourRepository;

@Service
public class ItineraryServiceImpl implements ItineraryService{
	 @Autowired
	    private ItineraryRepository itineraryRepository;

	    @Autowired
	    private TourRepository tourRepository;

	   

	    public Itinerary createItinerary(Integer tourId, Itinerary itinerary) {
	        Tour tour = tourRepository.findById(tourId)
	            .orElseThrow(() -> new NoSuchElementException("Tour not found with id " + tourId));
	        itinerary.setTour(tour);
	        return itineraryRepository.save(itinerary);
	    }

		@Override
		public List<Itinerary> getAllItineraries() {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public Itinerary getItineraryById(Integer id) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public List<Itinerary> getItinerariesByTourId(Integer tourId) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public Itinerary createItinerary(Itinerary itinerary) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public Itinerary updateItinerary(Integer id, Itinerary itinerary) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public void deleteItinerary(Integer id) {
			// TODO Auto-generated method stub
			
		}

	    // Additional business logic related to Itinerary can be added here
}
