package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.example.model.Booking;
import com.example.model.Customer;
import com.example.model.Tour;
import com.example.repository.BookingRepository;
import com.example.repository.CustomerRepository;
import com.example.repository.TourRepository;

@Service
public class BookingServiceImpl implements BookingService {

    @Autowired
    private BookingRepository bookingRepository;

    @Autowired
    private CustomerRepository customerRepository;

    @Autowired
    private TourRepository tourRepository;

    @Override
    @Transactional
    public Booking createBooking(Booking booking) {
        // Ensure Customer is persisted
        Customer customer = customerRepository.save(booking.getCustomer_id());
        booking.setCustomer_id(customer);

        // Ensure Tour is persisted
        Tour tour = tourRepository.save(booking.getSubcategory_id());
        booking.setSubcategory_id(tour);

        return bookingRepository.save(booking);
    }

	@Override
	public Booking getBookingById(Integer id) {
		 return bookingRepository.findById(id).orElse(null);
	}

	@Override
	public List<Booking> getAllBookings() {
		 return bookingRepository.findAll();
	}

	@Override
	public Booking updateBooking(Integer id, Booking booking) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void deleteBooking(Integer id) {
		// TODO Auto-generated method stub
		
	}
}
