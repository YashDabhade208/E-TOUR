package com.example.service;

import com.example.model.Category;




import java.util.*;


public interface CategoryService {

	List<Category> getAllCategories();
    Category getCategoryById(Integer id);
    Category createCategory(Category category);
    Category updateCategory(Category category);
    void deleteCategory(Integer id);
}
