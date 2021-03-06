﻿// <auto-generated />
using System;
using HotSauceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotSauceApp.Migrations
{
    [DbContext(typeof(HotSauceDbContext))]
    [Migration("20190708204424_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotSauceApp.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Total");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("HotSauceApp.Models.CartProduct", b =>
                {
                    b.Property<int>("CartID");

                    b.Property<int>("ProductID");

                    b.Property<int>("PriceTotal");

                    b.Property<int>("Quantity");

                    b.HasKey("CartID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("HotSauceApp.Models.Checkout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("State");

                    b.Property<decimal>("Total");

                    b.Property<string>("UserID");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("HotSauceApp.Models.CheckoutProduct", b =>
                {
                    b.Property<int>("CheckoutID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("CheckoutID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("CheckoutProducts");
                });

            modelBuilder.Entity("HotSauceApp.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("SKU");

                    b.Property<string>("Size");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HotSauceApp.Models.CartProduct", b =>
                {
                    b.HasOne("HotSauceApp.Models.Cart", "Cart")
                        .WithMany("CardProducts")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotSauceApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HotSauceApp.Models.CheckoutProduct", b =>
                {
                    b.HasOne("HotSauceApp.Models.Checkout", "Checkout")
                        .WithMany("CheckoutProducts")
                        .HasForeignKey("CheckoutID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotSauceApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
