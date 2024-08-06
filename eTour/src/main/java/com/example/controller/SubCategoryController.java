package com.example.controller;

import com.example.model.SubCategory;
import com.example.service.SubCategoryService;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/subcategories")
public class SubCategoryController {

    @Autowired
    private SubCategoryService subCategoryService;

    @GetMapping
    public ResponseEntity<List<SubCategory>> getAllSubCategories() {
        return new ResponseEntity<>(subCategoryService.getAllSubCategories(), HttpStatus.OK);
    }

    @GetMapping("/{id}")
    public ResponseEntity<SubCategory> getSubCategoryById(@PathVariable Integer id) {
        return new ResponseEntity<>(subCategoryService.getSubCategoryById(id), HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<SubCategory> createSubCategory(@RequestBody SubCategory subCategory) {
        return new ResponseEntity<>(subCategoryService.createSubCategory(subCategory), HttpStatus.CREATED);
    }

    @PutMapping("/{id}")
    public ResponseEntity<SubCategory> updateSubCategory(@PathVariable Integer id, @RequestBody SubCategory subCategory) {
        subCategory.setId(id);
        return new ResponseEntity<>(subCategoryService.updateSubCategory(subCategory), HttpStatus.OK);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteSubCategory(@PathVariable Integer id) {
        subCategoryService.deleteSubCategory(id);
        return new ResponseEntity<>(HttpStatus.NO_CONTENT);
    }
}