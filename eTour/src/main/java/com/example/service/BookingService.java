package com.example.service;

import java.util.List;
import java.util.Optional;

import com.example.model.Booking;
import com.example.model.Passenger;

public interface BookingService {
    Booking createBooking(Booking booking, List<Passenger> passengers);
    
	Optional<Booking> getBookingById(Integer id);
}