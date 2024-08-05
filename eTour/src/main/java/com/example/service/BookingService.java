package com.example.service;

import com.example.model.Booking;
import java.util.List;

public interface BookingService {
    Booking saveBooking(Booking booking);
    Booking updateBooking(Booking booking);
    void deleteBooking(Integer bookingId);
    Booking getBookingById(Integer bookingId);
    List<Booking> getAllBookings();
}
