package com.example.controller;

import com.example.model.Date;
import com.example.service.DateService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/dates")
public class DateController {

    @Autowired
    private DateService dateService;

    @PostMapping
    public ResponseEntity<Date> createDate(@RequestBody Date date) {
        Date savedDate = dateService.saveDate(date);
        return ResponseEntity.ok(savedDate);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Date> updateDate(@PathVariable Integer id, @RequestBody Date date) {
        date.setDeparture_id(id);
        Date updatedDate = dateService.updateDate(date);
        return ResponseEntity.ok(updatedDate);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteDate(@PathVariable Integer id) {
        dateService.deleteDate(id);
        return ResponseEntity.noContent().build();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Date> getDateById(@PathVariable Integer id) {
        Date date = dateService.getDateById(id);
        return ResponseEntity.ok(date);
    }

    @GetMapping
    public ResponseEntity<List<Date>> getAllDates() {
        List<Date> dates = dateService.getAllDates();
        return ResponseEntity.ok(dates);
    }
}
