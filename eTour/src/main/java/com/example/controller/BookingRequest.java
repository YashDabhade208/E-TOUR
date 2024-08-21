package com.example.controller;

import java.util.List;

public class BookingRequest {
    private String firstname;
    private String lastname;
    private String mobileno;
    private String email;
    private String adhaarno;
    private String address;
    private String city;
    private String state;
    private String country;
    private String pincode;
    private Integer numberOfPassenger;
    private Integer numberOfChildWithBed;
    private Integer numberOfChildWithoutBed;
    private String bookingDate;
    private List<PassengerRequest> passengers;

   

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

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getAdhaarno() {
        return adhaarno;
    }

    public void setAdhaarno(String adhaarno) {
        this.adhaarno = adhaarno;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public String getPincode() {
        return pincode;
    }

    public void setPincode(String pincode) {
        this.pincode = pincode;
    }

    public Integer getNumberOfPassenger() {
        return numberOfPassenger;
    }

    public void setNumberOfPassenger(Integer numberOfPassenger) {
        this.numberOfPassenger = numberOfPassenger;
    }

    public Integer getNumberOfChildWithBed() {
        return numberOfChildWithBed;
    }

    public void setNumberOfChildWithBed(Integer numberOfChildWithBed) {
        this.numberOfChildWithBed = numberOfChildWithBed;
    }

    public Integer getNumberOfChildWithoutBed() {
        return numberOfChildWithoutBed;
    }

    public void setNumberOfChildWithoutBed(Integer numberOfChildWithoutBed) {
        this.numberOfChildWithoutBed = numberOfChildWithoutBed;
    }

    public String getBookingDate() {
        return bookingDate;
    }

    public void setBookingDate(String bookingDate) {
        this.bookingDate = bookingDate;
    }

    public List<PassengerRequest> getPassengers() {
        return passengers;
    }

    public void setPassengers(List<PassengerRequest> passengers) {
        this.passengers = passengers;
    }

   
    public static class PassengerRequest {
        private String name;
        private Integer age;
        private String mobileNo;
        private String email;

       
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
    }
}
