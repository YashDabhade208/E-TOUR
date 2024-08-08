package com.example.model;

import jakarta.persistence.*;
@Entity
public class SubCategory {
		@Id
	    @GeneratedValue(strategy = GenerationType.IDENTITY)
	    private Integer subcategory_id;

	    @Column(nullable = false, length = 255)
	    private String name;
	    
	    @ManyToOne
	    @JoinColumn
	    private Category category_id;
	    
	    // Getters and setters
	    public Integer getId() {
	        return subcategory_id;
	    }
	    
	    public void setId(Integer id) {
	        this.subcategory_id = id;
	    }
	    
	    public String getName() {
	        return name;
	    }
	    
	    public void setName(String name) {
	        this.name = name;
	    }
	    
	    public Category getCategory() {
	        return category_id;
	    }
	    
	    public void setCategory(Category category_id) {
	        this.category_id = category_id;
	    }

}
