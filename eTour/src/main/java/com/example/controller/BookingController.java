package com.example.controller;

// BookingController.java
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Booking;
import com.example.model.Passenger;
import com.example.service.BookingService;


@RestController
@RequestMapping("/api/bookings")
public class BookingController {
    @Autowired
    private BookingService bookingService;

    @PostMapping
    public ResponseEntity<Booking> createBooking(@RequestBody BookingRequest request) {
        Booking booking = new Booking();
        booking.setFirstname(request.getFirstname());
        booking.setLastname(request.getLastname());
        booking.setMobileno(request.getMobileno());
        // Set other booking fields...

        List<Passenger> passengers = request.getPassengers().stream().map(p -> {
            Passenger passenger = new Passenger();
            passenger.setName(p.getName());
            passenger.setAge(p.getAge());
            passenger.setMobileNo(p.getMobileNo());
            passenger.setEmail(p.getEmail());
            return passenger;
        }).toList();

        Booking savedBooking = bookingService.createBooking(booking, passengers);
        return new ResponseEntity<>(savedBooking, HttpStatus.CREATED);
    }

    // Other methods
}

class BookingRequest {
    private String firstname;
    private String lastname;
    private String mobileno;
    // Other booking fields...

    private List<PassengerRequest> passengers;

    // Getters and setters
    

    public String getFirstname() {
		return firstname;
	}

	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}

	public String getLastname() {
		return lastname;
	}

	public void setLastname(String lastname) {
		this.lastname = lastname;
	}

	public String getMobileno() {
		return mobileno;
	}

	public void setMobileno(String mobileno) {
		this.mobileno = mobileno;
	}

	public List<PassengerRequest> getPassengers() {
		return passengers;
	}

	public void setPassengers(List<PassengerRequest> passengers) {
		this.passengers = passengers;
	}

	// Nested class for passenger details
    public static class PassengerRequest {
        public String getName() {
			return name;
		}
		public void setName(String name) {
			this.name = name;
		}
		public Integer getAge() {
			return age;
		}
		public void setAge(Integer age) {
			this.age = age;
		}
		public String getMobileNo() {
			return mobileNo;
		}
		public void setMobileNo(String mobileNo) {
			this.mobileNo = mobileNo;
		}
		public String getEmail() {
			return email;
		}
		public void setEmail(String email) {
			this.email = email;
		}
		private String name;
        private Integer age;
        private String mobileNo;
        private String email;

        // Getters and setters
    }
}
