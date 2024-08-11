package com.example.controller;

import java.util.ArrayList;
// BookingController.java
import java.util.List;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Booking;
import com.example.model.Passenger;
import com.example.service.BookingService;


@RestController
@RequestMapping("/api/bookings")
@CrossOrigin("*")
public class BookingController {
    @Autowired
    private BookingService bookingService;

    @PostMapping
    public ResponseEntity<Booking> createBooking(@RequestBody BookingRequest request) {
        Booking booking = new Booking();
        booking.setFirstname(request.getFirstname());
        booking.setLastname(request.getLastname());
        booking.setMobileno(request.getMobileno());
        booking.setEmail(request.getEmail());
        booking.setAdhaarno(request.getAdhaarno());
        booking.setAddress(request.getAddress());
        booking.setCity(request.getCity());
        booking.setState(request.getState());
        booking.setCountry(request.getCountry());
        booking.setPincode(request.getPincode());
        booking.setNumberOfPassenger(request.getNumberOfPassenger());
        booking.setNumberOfChildWithBed(request.getNumberOfChildWithBed());
        booking.setNumberOfChildWithoutBed(request.getNumberOfChildWithoutBed());
        booking.setBookingDate(request.getBookingDate());

        List<Passenger> passengers = (request.getPassengers() != null ? request.getPassengers() : new ArrayList<>()).stream()
                .map(p -> {
                    if (p instanceof BookingRequest.PassengerRequest) {
                        BookingRequest.PassengerRequest passengerRequest = (BookingRequest.PassengerRequest) p;
                        Passenger passenger = new Passenger();
                        passenger.setName(passengerRequest.getName());
                        passenger.setAge(passengerRequest.getAge());
                        passenger.setMobileNo(passengerRequest.getMobileNo());
                        passenger.setEmail(passengerRequest.getEmail());
                        return passenger;
                    } else {
                        throw new IllegalArgumentException("Unexpected type of PassengerRequest");
                    }
                })
            .collect(Collectors.toList());

        Booking savedBooking = bookingService.createBooking(booking, passengers);
        return new ResponseEntity<>(savedBooking, HttpStatus.CREATED);
    }
    
    
    @GetMapping
    public ResponseEntity<List<Booking>> getAllBookings() {
        List<Booking> bookings = bookingService.getAllBookings();
        return new ResponseEntity<>(bookings, HttpStatus.OK);
    }

    @GetMapping("/{id}")
    public ResponseEntity<Booking> getBookingById(@PathVariable Integer id) {
        Booking booking = bookingService.getBookingById(id);
        if (booking != null) {
            return new ResponseEntity<>(booking, HttpStatus.OK);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<Booking> updateBooking(@PathVariable Integer id, @RequestBody BookingRequest request) {
        Booking existingBooking = bookingService.getBookingById(id);
        if (existingBooking != null) {
            // Update booking fields from request
            existingBooking.setFirstname(request.getFirstname());
            existingBooking.setLastname(request.getLastname());
            existingBooking.setMobileno(request.getMobileno());
            existingBooking.setEmail(request.getEmail());
            existingBooking.setAdhaarno(request.getAdhaarno());
            existingBooking.setAddress(request.getAddress());
            existingBooking.setCity(request.getCity());
            existingBooking.setState(request.getState());
            existingBooking.setCountry(request.getCountry());
            existingBooking.setPincode(request.getPincode());
            existingBooking.setNumberOfPassenger(request.getNumberOfPassenger());
            existingBooking.setNumberOfChildWithBed(request.getNumberOfChildWithBed());
            existingBooking.setNumberOfChildWithoutBed(request.getNumberOfChildWithoutBed());
            existingBooking.setBookingDate(request.getBookingDate());

            // Update passengers
            List<Passenger> passengers = request.getPassengers().stream()
                .map(passengerRequest -> {
                    Passenger passenger = new Passenger();
                    passenger.setName(passengerRequest.getName());
                    passenger.setAge(passengerRequest.getAge());
                    passenger.setMobileNo(passengerRequest.getMobileNo());
                    passenger.setEmail(passengerRequest.getEmail());
                    passenger.setBooking(existingBooking);
                    return passenger;
                }).collect(Collectors.toList());
            existingBooking.setPassengers(passengers);

            Booking updatedBooking = bookingService.updateBooking(existingBooking);
            return new ResponseEntity<>(updatedBooking, HttpStatus.OK);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteBooking(@PathVariable Integer id) {
        Booking existingBooking = bookingService.getBookingById(id);
        if (existingBooking != null) {
            bookingService.deleteBooking(id);
            return new ResponseEntity<>(HttpStatus.NO_CONTENT);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

   
}