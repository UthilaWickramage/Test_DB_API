﻿// <auto-generated />
using System;
using EFModels.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFModels.Migrations
{
    [DbContext(typeof(TRSDBContext))]
    [Migration("20240403072909_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFModels.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Customer_Mobile_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EFModels.Model.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int>("No_Of_Adults")
                        .HasColumnType("int");

                    b.Property<int>("No_Of_Toddlers")
                        .HasColumnType("int");

                    b.Property<DateTime>("Request_Date_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reservation_Date_Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("EFModels.Model.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly>("Opening_Time")
                        .HasColumnType("time");

                    b.Property<string>("Restaurant_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("EFModels.Model.Restaurant_Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("No_Of_Seats")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Restaurants_Table");
                });

            modelBuilder.Entity("ReservationRestaurant_Table", b =>
                {
                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.Property<int>("Restaurant_TablesId")
                        .HasColumnType("int");

                    b.HasKey("ReservationsId", "Restaurant_TablesId");

                    b.HasIndex("Restaurant_TablesId");

                    b.ToTable("ReservationRestaurant_Table");
                });

            modelBuilder.Entity("EFModels.Model.Customer", b =>
                {
                    b.HasOne("EFModels.Model.Restaurant", null)
                        .WithMany("Customers")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("EFModels.Model.Reservation", b =>
                {
                    b.HasOne("EFModels.Model.Customer", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("EFModels.Model.Restaurant", null)
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("EFModels.Model.Restaurant_Table", b =>
                {
                    b.HasOne("EFModels.Model.Restaurant", null)
                        .WithMany("Restaurant_Tables")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("ReservationRestaurant_Table", b =>
                {
                    b.HasOne("EFModels.Model.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFModels.Model.Restaurant_Table", null)
                        .WithMany()
                        .HasForeignKey("Restaurant_TablesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFModels.Model.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("EFModels.Model.Restaurant", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Reservations");

                    b.Navigation("Restaurant_Tables");
                });
#pragma warning restore 612, 618
        }
    }
}
