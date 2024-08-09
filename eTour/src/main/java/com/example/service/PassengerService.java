package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Passenger;
import com.example.repository.PassengerRepository;

@Service
public class PassengerService {

    @Autowired
    private PassengerRepository passengerRepository;

    public Passenger savePassenger(Passenger passenger) {
        return passengerRepository.save(passenger);
    }

    public Optional<Passenger> getPassengerById(Integer id) {
        return passengerRepository.findById(id);
    }

    public List<Passenger> getAllPassengers() {
        return passengerRepository.findAll();
    }

    public void deletePassenger(Integer id) {
        passengerRepository.deleteById(id);
    }
}
