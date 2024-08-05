package com.example.service;

import com.example.model.Category;
import java.util.List;

public interface CategoryService {
    Category saveCategory(Category category);
    Category updateCategory(Category category);
    void deleteCategory(Integer categoryId);
    Category getCategoryById(Integer categoryId);
    List<Category> getAllCategories();
}
