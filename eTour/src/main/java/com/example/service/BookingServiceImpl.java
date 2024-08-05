package com.example.service;

import com.example.model.Booking;
import com.example.repository.BookingRepository;
import com.example.service.BookingService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class BookingServiceImpl implements BookingService {

    @Autowired
    private BookingRepository bookingRepository;

    @Override
    public Booking saveBooking(Booking booking) {
        return bookingRepository.save(booking);
    }

    @Override
    public Booking updateBooking(Booking booking) {
        return bookingRepository.save(booking);
    }

    @Override
    public void deleteBooking(Integer bookingId) {
        bookingRepository.deleteById(bookingId);
    }

    @Override
    public Booking getBookingById(Integer bookingId) {
        Optional<Booking> optionalBooking = bookingRepository.findById(bookingId);
        return optionalBooking.orElse(null);
    }

    @Override
    public List<Booking> getAllBookings() {
        return bookingRepository.findAll();
    }
}
