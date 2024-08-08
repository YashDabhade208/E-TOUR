package com.example.service;

import com.example.model.Booking;
import com.example.repository.BookingRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;


@Service
public class BookingServiceImpl implements BookingService
{

    @Autowired
    private BookingRepository bookingRepository;

    public List<Booking> getAllBookings() {
        return bookingRepository.findAll();
    }

    public Booking getBookingById(Integer id) {
        return bookingRepository.findById(id).orElseThrow();
    }

    public Booking createBooking(Booking booking) {
        return bookingRepository.save(booking);
    }

    public Booking updateBooking(Integer id, Booking booking) {
        Booking existingBooking = getBookingById(id);
        existingBooking.setFirstname(booking.getFirstname());
        existingBooking.setLastname(booking.getLastname());
        existingBooking.setAge(booking.getAge());
        existingBooking.setMobileno(booking.getMobileno());
        existingBooking.setNumberofpassenger(booking.getNumberofpassenger());
        existingBooking.setGender(booking.getGender());
        existingBooking.setDateofbirth(booking.getDateofbirth());
        existingBooking.setEmail(booking.getEmail());
        existingBooking.setAdhaarno(booking.getAdhaarno());
        existingBooking.setAdress(booking.getAdress());
        existingBooking.setCity(booking.getCity());
        existingBooking.setState(booking.getState());
        existingBooking.setCountry(booking.getCountry());
        existingBooking.setPincode(booking.getPincode());
        existingBooking.setNumberofchild(booking.getNumberofchild());
        existingBooking.setNumberofchildwithbed(booking.getNumberofchildwithbed());
        existingBooking.setNumberofchildwithoutbed(booking.getNumberofchildwithoutbed());
        existingBooking.setBookingdate(booking.getBookingdate());
        existingBooking.setCustomer_id(booking.getCustomer_id());
        existingBooking.setSubcategory_id(booking.getSubcategory_id());
        return bookingRepository.save(existingBooking);
    }
    

    public void deleteBooking(Integer id) {
        bookingRepository.deleteById(id);
    }
}