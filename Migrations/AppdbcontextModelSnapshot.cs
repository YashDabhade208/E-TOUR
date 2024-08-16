﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTour.Repository;

#nullable disable

namespace eTour.Migrations
{
    [DbContext(typeof(Appdbcontext))]
    partial class AppdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eTour.Model.Booking", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"));

                    b.Property<DateTime>("Booking_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int>("NoofChildWithBed")
                        .HasColumnType("int");

                    b.Property<int>("NoofChildWithoutBed")
                        .HasColumnType("int");

                    b.Property<int>("TotalPassengers")
                        .HasColumnType("int");

                    b.HasKey("Booking_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("eTour.Model.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_Id"));

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("eTour.Model.Cost", b =>
                {
                    b.Property<int>("Cost_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cost_id"));

                    b.Property<int>("Childwithbed")
                        .HasColumnType("int");

                    b.Property<int>("Childwithoutbed")
                        .HasColumnType("int");

                    b.Property<int>("Tour_Cost")
                        .HasColumnType("int");

                    b.Property<int>("Tour_Id")
                        .HasColumnType("int");

                    b.HasKey("Cost_id");

                    b.HasIndex("Tour_Id");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("eTour.Model.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_Id"));

                    b.Property<string>("Customer_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Dateofbirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_MobNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Customer_age")
                        .HasColumnType("int");

                    b.Property<string>("Customer_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("eTour.Model.Iternery", b =>
                {
                    b.Property<int>("Iternery_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Iternery_Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tour_Id")
                        .HasColumnType("int");

                    b.HasKey("Iternery_Id");

                    b.HasIndex("Tour_Id");

                    b.ToTable("Iterneries");
                });

            modelBuilder.Entity("eTour.Model.Passenger", b =>
                {
                    b.Property<int>("Passenger_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Passenger_Id"));

                    b.Property<int>("Booking_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int>("Passenger_Age")
                        .HasColumnType("int");

                    b.Property<string>("Passenger_Bed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passenger_EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passenger_Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passenger_MobNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passenger_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Passenger_Id");

                    b.HasIndex("Booking_Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("eTour.Model.Payment", b =>
                {
                    b.Property<int>("Payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Payment_Id"));

                    b.Property<int>("Booking_Id")
                        .HasColumnType("int");

                    b.Property<string>("Payment_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total_Cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payment_Id");

                    b.HasIndex("Booking_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("eTour.Model.SubCategory", b =>
                {
                    b.Property<int>("Subcategory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Subcategory_Id"));

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("Subcategory_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Subcategory_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("eTour.Model.TourDate", b =>
                {
                    b.Property<int>("Tourdate_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tourdate_Id"));

                    b.Property<int>("Tour_Id")
                        .HasColumnType("int");

                    b.Property<string>("Validfrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tourdate_Id");

                    b.HasIndex("Tour_Id");

                    b.ToTable("TourDates");
                });

            modelBuilder.Entity("eTour.Model.Tours", b =>
                {
                    b.Property<int>("Tour_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tour_Id"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("SubCategory_Id")
                        .HasColumnType("int");

                    b.Property<string>("Tour_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tour_Id");

                    b.HasIndex("SubCategory_Id");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("eTour.Model.Booking", b =>
                {
                    b.HasOne("eTour.Model.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("eTour.Model.Cost", b =>
                {
                    b.HasOne("eTour.Model.Tours", "Tours")
                        .WithMany()
                        .HasForeignKey("Tour_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("eTour.Model.Iternery", b =>
                {
                    b.HasOne("eTour.Model.Tours", "Tours")
                        .WithMany("Iterneries")
                        .HasForeignKey("Tour_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("eTour.Model.Passenger", b =>
                {
                    b.HasOne("eTour.Model.Booking", "Booking")
                        .WithMany("Passsengers")
                        .HasForeignKey("Booking_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTour.Model.Customer", null)
                        .WithMany("Passengers")
                        .HasForeignKey("Customer_Id");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("eTour.Model.Payment", b =>
                {
                    b.HasOne("eTour.Model.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("Booking_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("eTour.Model.SubCategory", b =>
                {
                    b.HasOne("eTour.Model.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eTour.Model.TourDate", b =>
                {
                    b.HasOne("eTour.Model.Tours", "Tours")
                        .WithMany("Dates")
                        .HasForeignKey("Tour_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("eTour.Model.Tours", b =>
                {
                    b.HasOne("eTour.Model.SubCategory", "Subcategory")
                        .WithMany("Tours")
                        .HasForeignKey("SubCategory_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("eTour.Model.Booking", b =>
                {
                    b.Navigation("Passsengers");
                });

            modelBuilder.Entity("eTour.Model.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("eTour.Model.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Passengers");
                });

            modelBuilder.Entity("eTour.Model.SubCategory", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("eTour.Model.Tours", b =>
                {
                    b.Navigation("Dates");

                    b.Navigation("Iterneries");
                });
#pragma warning restore 612, 618
        }
    }
}
