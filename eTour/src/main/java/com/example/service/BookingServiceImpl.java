package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Booking;
import com.example.model.Passenger;
import com.example.repository.BookingRepository;
import com.example.repository.PassengerRepository;

import jakarta.transaction.Transactional;

@Service
public class BookingServiceImpl implements BookingService {
    @Autowired
    private BookingRepository bookingRepository;

    @Autowired
    private PassengerRepository passengerRepository;

    public Booking createBooking(Booking booking, List<Passenger> passengers) {
        
        Booking savedBooking = bookingRepository.save(booking);
        
       
        for (Passenger passenger : passengers) {
            passenger.setBooking(savedBooking);
            passengerRepository.save(passenger);
        }

        return savedBooking;
    }

    public List<Booking> getAllBookings() {
        return bookingRepository.findAll();
    }

    public Booking getBookingById(Integer id) {
        return bookingRepository.findById(id).orElse(null);
    }

    public Booking updateBooking(Booking booking) {
        return bookingRepository.save(booking);
    }

    public void deleteBooking(Integer id) {
        bookingRepository.deleteById(id);
    }
}