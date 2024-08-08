package com.example.service;

import com.example.model.Booking;
import java.util.List;

public interface BookingService {
	public Booking getBookingById(Integer id);
	public List<Booking> getAllBookings();
	public Booking createBooking(Booking booking);
	public Booking updateBooking(Integer id, Booking booking);
	public void deleteBooking(Integer id);
}
