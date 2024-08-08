package com.example.service;

import java.util.*;



import com.example.model.SubCategory;

public interface SubCategoryService {
	 	List<SubCategory> getAllSubCategories();
	    SubCategory getSubCategoryById(Integer id);
	    SubCategory createSubCategory(SubCategory subCategory);
	    SubCategory updateSubCategory(SubCategory subCategory);
	    void deleteSubCategory(Integer id);
	
}
