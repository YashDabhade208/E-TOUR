package com.example.service;

import com.example.model.Customer;
import com.example.repository.CustomerRepository;

import jakarta.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CustomerService {
    
    @Autowired
    private CustomerRepository customerRepository;

    public Customer createCustomer(Customer customer) {
        return customerRepository.save(customer);
    }

    public Optional<Customer> getCustomerById(Integer customerId) {
        return customerRepository.findById(customerId);
    }

    public List<Customer> getAllCustomers() {
        return customerRepository.findAll();
    }
    @Transactional
    public Customer updateCustomer(Integer id,Customer customer) {
        Customer existingCustomer = customerRepository.findById(id).orElseThrow();
        existingCustomer.setCustomer_firstname(customer.getCustomer_firstname());
        existingCustomer.setCustomer_lastname(customer.getCustomer_lastname());
        existingCustomer.setCustomer_gender(customer.getCustomer_gender());
        existingCustomer.setCustomer_dob(customer.getCustomer_dob());
        existingCustomer.setCustomer_username(customer.getCustomer_username());
        existingCustomer.setCustomer_password(customer.getCustomer_password());
        existingCustomer.setCustomer_mobileno(customer.getCustomer_mobileno());
        existingCustomer.setCustomer_emailid(customer.getCustomer_emailid());
        existingCustomer.setCustomer_address(customer.getCustomer_address());
        existingCustomer.setCustomer_city(customer.getCustomer_city());
        existingCustomer.setCustomer_state(customer.getCustomer_state());
        existingCustomer.setCustomer_pincode(customer.getCustomer_pincode());
        return customerRepository.save(existingCustomer);
    }

    public void deleteCustomer(Integer customerId) {
        customerRepository.deleteById(customerId);
    }
    
    
    public boolean validateCustomer(String email, String password) {
        Customer customer = customerRepository.getUserByEmailIdAndPass(email, password);
        return customer != null;
    }
}