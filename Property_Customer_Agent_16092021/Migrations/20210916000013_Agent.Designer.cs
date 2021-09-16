﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Property_Customer_Agent_16092021.Data;

namespace Property_Customer_Agent_16092021.Migrations
{
    [DbContext(typeof(Property_Customer_Agent_16092021Context))]
    [Migration("20210916000013_Agent")]
    partial class Agent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Property_Customer_Agent_16092021.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agent_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Agent_Mobile")
                        .HasColumnType("int");

                    b.Property<string>("Agent_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office_Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("Property_Customer_Agent_16092021.Models.Customer", b =>
                {
                    b.Property<string>("Cust_Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cust_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cust_Mobile")
                        .HasColumnType("int");

                    b.Property<string>("Cust_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cust_Username");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Property_Customer_Agent_16092021.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Property_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Property_Number_of_Bathrooms")
                        .HasColumnType("int");

                    b.Property<int>("Property_Number_of_Bedrooms")
                        .HasColumnType("int");

                    b.Property<int>("Property_WeeklyRent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
