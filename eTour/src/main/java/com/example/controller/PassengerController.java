package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Passenger;
import com.example.service.PassengerService;

@RestController
@RequestMapping("/api/passengers")
public class PassengerController {

    @Autowired
    private PassengerService passengerService;

    // Create a new passenger
    @PostMapping
    public ResponseEntity<Passenger> createPassenger(@RequestBody Passenger passenger) {
        try {
            Passenger createdPassenger = passengerService.savePassenger(passenger);
            return new ResponseEntity<>(createdPassenger, HttpStatus.CREATED);
        } catch (Exception e) {
            return new ResponseEntity<>(null, HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    // Get a passenger by ID
    @GetMapping("/{id}")
    public ResponseEntity<Passenger> getPassengerById(@PathVariable("id") Integer id) {
        Optional<Passenger> passenger = passengerService.getPassengerById(id);
        if (passenger.isPresent()) {
            return new ResponseEntity<>(passenger.get(), HttpStatus.OK);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

    // Get all passengers (Optional, if needed)
    @GetMapping
    public ResponseEntity<List<Passenger>> getAllPassengers() {
        List<Passenger> passengers = passengerService.getAllPassengers();
        return new ResponseEntity<>(passengers, HttpStatus.OK);
    }

    // Update a passenger by ID
    @PutMapping("/{id}")
    public ResponseEntity<Passenger> updatePassenger(@PathVariable("id") Integer id, @RequestBody Passenger passenger) {
        Optional<Passenger> existingPassenger = passengerService.getPassengerById(id);
        if (existingPassenger.isPresent()) {
            passenger.setId(id);
            Passenger updatedPassenger = passengerService.savePassenger(passenger);
            return new ResponseEntity<>(updatedPassenger, HttpStatus.OK);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

    // Delete a passenger by ID
    @DeleteMapping("/{id}")
    public ResponseEntity<HttpStatus> deletePassenger(@PathVariable("id") Integer id) {
        try {
            passengerService.deletePassenger(id);
            return new ResponseEntity<>(HttpStatus.NO_CONTENT);
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
