package com.example.model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name="Category_Master")
public class Category
{
	
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(nullable=false,length=5)
	@Id
	private Integer Catmaster_id;

	@Column(nullable=false,length=3)
	
	private String Category_id;

	@Column(length=3)
	private String SubCategory_id;

	@Column(length=255)
	private String Category_Name;

	@Column(length=255)
	private String Category_Image_Path;

	private boolean flag;

	public Integer getCatmaster_id() {
		return Catmaster_id;
	}

	public void setCatmaster_id(Integer catmaster_id) {
		Catmaster_id = catmaster_id;
	}

	public String getCategory_id() {
		return Category_id;
	}

	public void setCategory_id(String category_id) {
		Category_id = category_id;
	}

	public String getSubCategory_id() {
		return SubCategory_id;
	}

	public void setSubCategory_id(String subCategory_id) {
		SubCategory_id = subCategory_id;
	}

	public String getCategory_Name() {
		return Category_Name;
	}

	public void setCategory_Name(String category_Name) {
		Category_Name = category_Name;
	}

	public String getCategory_Image_Path() {
		return Category_Image_Path;
	}

	public void setCategory_Image_Path(String category_Image_Path) {
		Category_Image_Path = category_Image_Path;
	}

	public boolean isFlag() {
		return flag;
	}

	public void setFlag(boolean flag) {
		this.flag = flag;
	}



}
