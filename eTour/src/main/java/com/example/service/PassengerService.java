package com.example.service;

import com.example.model.Passenger;
import java.util.List;

public interface PassengerService {
    Passenger savePassenger(Passenger passenger);
    Passenger updatePassenger(Passenger passenger);
    void deletePassenger(Integer passengerId);
    Passenger getPassengerById(Integer passengerId);
    List<Passenger> getAllPassengers();
}
