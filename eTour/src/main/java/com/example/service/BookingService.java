package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;

import com.example.controller.BookingRequest;
import com.example.model.Booking;
import com.example.model.Passenger;

public interface BookingService 
{
	public void deleteBooking(Integer id);
	 public Booking updateBooking(Booking booking);
	 public Booking getBookingById(Integer id);
	  public List<Booking> getAllBookings();
	  public Booking createBooking(Booking booking, List<Passenger> passengers);
}