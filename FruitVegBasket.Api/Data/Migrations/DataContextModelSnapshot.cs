﻿// <auto-generated />
using System;
using FruitVegBasket.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FruitVegBasket.Api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Address2")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Category", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Credit")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<short>("ParentId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = (short)1,
                            Credit = "Photo by <a href=\"https://unsplash.com/@juliazolotova?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Julia Zolotova</a> on <a href=\"https://unsplash.com/photos/M_xIaxQE3Ms?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "fruits.png",
                            Name = "Fruits",
                            ParentId = (short)0
                        },
                        new
                        {
                            Id = (short)2,
                            Credit = "Photo by <a href=\"https://unsplash.com/@rejaul_creativedesign?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rejaul Karim</a> on <a href=\"https://unsplash.com/photos/uI3SmaQeu6o?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "seasonal_fruits.png",
                            Name = "Seasonal Fruits",
                            ParentId = (short)1
                        },
                        new
                        {
                            Id = (short)3,
                            Credit = "Photo by <a href=\"https://unsplash.com/@alschim?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Alexander Schimmeck</a> on <a href=\"https://unsplash.com/photos/9YVh9yQvvvk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "exotic_fruits.png",
                            Name = "Exotic Fruits",
                            ParentId = (short)1
                        },
                        new
                        {
                            Id = (short)4,
                            Credit = "Photo by <a href=\"https://unsplash.com/@marisolbenitez?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Marisol Benitez</a> on <a href=\"https://unsplash.com/photos/QvkAQTNj4zk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "vegetables.png",
                            Name = "Vegetables",
                            ParentId = (short)0
                        },
                        new
                        {
                            Id = (short)5,
                            Credit = "Photo by Viktoria  Slowikowska: https://www.pexels.com/photo/sweet-corn-and-green-vegetables-on-blue-surface-5678106/",
                            Image = "green_vegetables.png",
                            Name = "Green Vegetables",
                            ParentId = (short)4
                        },
                        new
                        {
                            Id = (short)6,
                            Credit = "Photo by <a href=\"https://unsplash.com/@woonsa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Soo Ann Woon</a> on <a href=\"https://unsplash.com/photos/0l_NXp3StHE?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "leafy_vegetables.png",
                            Name = "Leafy Vegetables",
                            ParentId = (short)4
                        },
                        new
                        {
                            Id = (short)7,
                            Credit = "Photo by <a href=\"https://unsplash.com/@nadineprimeau?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Nadine Primeau</a> on <a href=\"https://unsplash.com/photos/-ftWfohtjNw?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "salads.png",
                            Name = "Salads",
                            ParentId = (short)4
                        },
                        new
                        {
                            Id = (short)8,
                            Credit = "Photo by <a href=\"https://unsplash.com/@picoftasty?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mae Mu</a> on <a href=\"https://unsplash.com/photos/ru4jyDiLHsI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "dairy.png",
                            Name = "Dairy",
                            ParentId = (short)0
                        },
                        new
                        {
                            Id = (short)9,
                            Credit = "Photo by <a href=\"https://unsplash.com/@mehrshadr?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mehrshad Rajabi</a> on <a href=\"https://unsplash.com/photos/P7MkoYvSnLI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "milk_curd_yogurt.png",
                            Name = "Milk, Curd & Yogurts",
                            ParentId = (short)8
                        },
                        new
                        {
                            Id = (short)10,
                            Credit = "Photo by Elle Hughes: https://www.pexels.com/photo/three-assorted-varieties-of-cheese-near-tableknife-1963288/",
                            Image = "butter_cheese.png",
                            Name = "Butter & Cheese",
                            ParentId = (short)8
                        },
                        new
                        {
                            Id = (short)11,
                            Credit = "Photo by <a href=\"https://unsplash.com/@rudy_issa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rudy Issa</a> on <a href=\"https://unsplash.com/photos/KVacTm0QeEA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "eggs_meat.png",
                            Name = "Eggs & Meat",
                            ParentId = (short)0
                        },
                        new
                        {
                            Id = (short)12,
                            Credit = "Photo by <a href=\"https://unsplash.com/@erol?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Erol Ahmed</a> on <a href=\"https://unsplash.com/photos/leOh1CzRZVQ?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "eggs.png",
                            Name = "Eggs",
                            ParentId = (short)11
                        },
                        new
                        {
                            Id = (short)13,
                            Credit = "Photo by <a href=\"https://unsplash.com/@shootdelicious?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Eiliv Aceron</a> on <a href=\"https://unsplash.com/photos/AQ_BdsvLgqA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "meat.png",
                            Name = "Meat",
                            ParentId = (short)11
                        },
                        new
                        {
                            Id = (short)14,
                            Credit = "Photo by <a href=\"https://unsplash.com/pt-br/@maxmota?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Max Mota</a> on <a href=\"https://unsplash.com/photos/N6BTNbaKZMo?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ",
                            Image = "seafood.png",
                            Name = "Seafood",
                            ParentId = (short)11
                        });
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BgColor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Offer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BgColor = "#e1f1e7",
                            Code = "FRT30",
                            Description = "Enjoy upto 30% off on all fruits",
                            IsActive = false,
                            Title = "Upto 30% off"
                        },
                        new
                        {
                            Id = 2,
                            BgColor = "#ffff00",
                            Code = "50OFF",
                            Description = "Enjoy our big offer of 50% off on all green vegetables",
                            IsActive = false,
                            Title = "Green Veg Big Sale 50% OFF"
                        },
                        new
                        {
                            Id = 3,
                            BgColor = "#e28083",
                            Code = "EXT100",
                            Description = "Flat Rs. 100 off on all exotic fruits and vegetables",
                            IsActive = false,
                            Title = "Flat 100 OFF"
                        },
                        new
                        {
                            Id = 4,
                            BgColor = "#e1f1e7",
                            Code = "FRT25",
                            Description = "Enjoy 25% off on all seasonal fruits",
                            IsActive = false,
                            Title = "25% OFF on Seasonal Fruits"
                        });
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("CategoryId")
                        .HasColumnType("smallint");

                    b.Property<string>("Image")
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Role", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = (short)1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = (short)2,
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("We should not have plain password. Having this just for simplicity and demo purpose");

                    b.Property<short>("RoleId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "abhayprince@outlok.com",
                            Mobile = "1234567890",
                            Name = "Abhay Prince",
                            Password = "123456",
                            RoleId = (short)1
                        });
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Address", b =>
                {
                    b.HasOne("FruitVegBasket.Api.Data.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Order", b =>
                {
                    b.HasOne("FruitVegBasket.Api.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("FruitVegBasket.Api.Data.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FruitVegBasket.Api.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Product", b =>
                {
                    b.HasOne("FruitVegBasket.Api.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.User", b =>
                {
                    b.HasOne("FruitVegBasket.Api.Data.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FruitVegBasket.Api.Data.Entities.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
