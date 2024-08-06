package com.example.service;

import com.example.model.Date;
import com.example.repository.DateRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class DateServiceImpl implements DateService {

    @Autowired
    private DateRepository dateRepository;

    @Override
    public Date saveDate(Date date) {
        return dateRepository.save(date);
    }

    @Override
    public Date updateDate(Date date) {
        return dateRepository.save(date);
    }

    @Override
    public void deleteDate(Integer dateId) {
        dateRepository.deleteById(dateId);
    }

    @Override
    public Date getDateById(Integer dateId) {
        Optional<Date> optionalDate = dateRepository.findById(dateId);
        return optionalDate.orElse(null);
    }

    @Override
    public List<Date> getAllDates() {
        return dateRepository.findAll();
    }
}
