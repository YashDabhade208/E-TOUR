package com.example.service;

import com.example.model.Passenger;
import com.example.repository.PassengerRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class PassengerServiceImpl implements PassengerService {

    @Autowired
    private PassengerRepository passengerRepository;

    @Override
    public Passenger savePassenger(Passenger passenger) {
        return passengerRepository.save(passenger);
    }

    @Override
    public Passenger updatePassenger(Passenger passenger) {
        return passengerRepository.save(passenger);
    }

    @Override
    public void deletePassenger(Integer passengerId) {
        passengerRepository.deleteById(passengerId);
    }

    @Override
    public Passenger getPassengerById(Integer passengerId) {
        Optional<Passenger> optionalPassenger = passengerRepository.findById(passengerId);
        return optionalPassenger.orElse(null);
    }

    @Override
    public List<Passenger> getAllPassengers() {
        return passengerRepository.findAll();
    }
}
