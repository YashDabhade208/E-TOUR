package com.example.service;

import com.example.model.Category;
import com.example.repository.CategoryRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class CategoryServiceImpl implements CategoryService
{
	 @Autowired
	    private CategoryRepository categoryRepository;

	@Override
	public List<Category> getAllCategories() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Category getCategoryById(Integer id) {
		return categoryRepository.findById(id).orElseThrow();
	}

	@Override
	public Category createCategory(Category category) {
		return categoryRepository.save(category);
	}

	@Override
	public Category updateCategory(Category category) {
		 return categoryRepository.save(category);
	}

	@Override
	public void deleteCategory(Integer id) {
		 categoryRepository.deleteById(id);
		
	}

	  
}
