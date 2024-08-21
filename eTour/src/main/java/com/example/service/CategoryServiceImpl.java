package com.example.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Category;
import com.example.repository.CategoryRepository;

@Service
public class CategoryServiceImpl implements CategoryService
{
	 @Autowired
	    private CategoryRepository categoryRepository;

	    public List<Category> getAllCategories() {
	        return categoryRepository.findAll();
	    }

	    public Category createCategory(Category category) {
	        return categoryRepository.save(category);
	    }

		@Override
		public Category getCategoryById(Integer id) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public Category updateCategory(Category category) {
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public void deleteCategory(Integer id) {
			// TODO Auto-generated method stub
			
		}

	
}
