﻿// <auto-generated />
using ApiBolsaTrabajoUTN.API.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBolsaTrabajoUTN.API.Migrations
{
    [DbContext(typeof(DBContexts.AppContext))]
    partial class ContentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApiBolsaTrabajoUTN", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Category 1",
                            Comment = "Comment 1",
                            Duration = 12,
                            Title = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Category 2",
                            Comment = "Comment 2",
                            Duration = 12,
                            Title = "Title 2"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Category 3",
                            Comment = "Comment 3",
                            Duration = 12,
                            Title = "Title 3"
                        });
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email1@email.com",
                            Password = "password1",
                            Username = "User 1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "email2@email.com",
                            Password = "password2",
                            Username = "User 2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "email3@email.com",
                            Password = "password3",
                            Username = "User 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
