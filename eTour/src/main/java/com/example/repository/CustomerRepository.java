package com.example.repository;

import com.example.model.Customer;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

@Repository
public interface CustomerRepository extends JpaRepository<Customer, Integer> {

    @Query(value = "SELECT * FROM customer WHERE customer_emailid = :emailId AND customer_password = :password", nativeQuery = true)
    Customer getUserByEmailIdAndPass(@Param("emailId") String emailId, @Param("password") String password);
}
