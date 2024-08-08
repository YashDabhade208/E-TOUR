package com.example.service;

import com.example.model.Date;
import java.util.List;

public interface DateService {
    Date saveDate(Date date);
    Date updateDate(Date date);
    void deleteDate(Integer dateId);
    Date getDateById(Integer dateId);
    List<Date> getAllDates();
}
