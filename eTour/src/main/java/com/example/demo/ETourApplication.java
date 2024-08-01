package com.example.demo;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.boot.autoconfigure.domain.EntityScan;

@SpringBootApplication
@EnableJpaRepositories(basePackages = {"com.example.repository"})
@EntityScan(basePackages = {"com.example.model"})
@ComponentScan(basePackages = {"com.example.repository", "com.example.service"})
public class ETourApplication 
{

    public static void main(String[] args) {
        SpringApplication.run(ETourApplication.class, args);
    }
}