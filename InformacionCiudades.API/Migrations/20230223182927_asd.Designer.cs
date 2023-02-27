﻿// <auto-generated />
using System;
using ApiBolsaTrabajoUTN.API.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBolsaTrabajoUTN.API.Migrations
{
    [DbContext(typeof(BolsaTrabajoContext))]
    [Migration("20230223182927_asd")]
    partial class asd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalSubjets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Careers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "TUP",
                            Name = "Tecnicatura Universitaria En Programacion",
                            TotalSubjets = 21,
                            Type = 1
                        });
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.JobPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CareerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("FrameworkAgreement")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("JobType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PositionsToCover")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkDay")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobPositions");
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkillName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ActiveAccount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FirstChargeData")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("JobPositionStudent", b =>
                {
                    b.Property<int>("JobAppliesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentsWhoAppliedId")
                        .HasColumnType("TEXT");

                    b.HasKey("JobAppliesId", "StudentsWhoAppliedId");

                    b.HasIndex("StudentsWhoAppliedId");

                    b.ToTable("JobPositionStudent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            ConcurrencyStamp = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "551753f0-bsd2–42de-ffbc-58kmgkmk71cd6",
                            ConcurrencyStamp = "551753f0-bsd2–42de-ffbc-58kmgkmk71cd6",
                            Name = "Company",
                            NormalizedName = "COMPANY"
                        },
                        new
                        {
                            Id = "599253f0-asd2–43de-cfbc-58kmgkmk71cd0",
                            ConcurrencyStamp = "599253f0-asd2–43de-cfbc-58kmgkmk71cd0",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            RoleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Admin", b =>
                {
                    b.HasBaseType("ApiBolsaTrabajoUTN.API.Entities.User");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Admin_FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Admin_LastName");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            Id = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            AccessFailedCount = 0,
                            ActiveAccount = false,
                            ConcurrencyStamp = "4b24e605-8ddc-4100-8111-62268847f8e3",
                            Email = "administracion@frro.utn.edu.ar",
                            EmailConfirmed = true,
                            FirstChargeData = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRACION@FRRO.UTN.EDU.AR",
                            NormalizedUserName = "ADMINISTRACION@FRRO.UTN.EDU.AR",
                            PasswordHash = "AQAAAAEAACcQAAAAENfkR+OOM+xEzUqpO84aCjBYIgnaKF+kBpB1h+EdOaXEyBG9dP6jPbDscAXBC/hg9Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "763905db-75f8-4fda-9316-fd5be58cd2c8",
                            TwoFactorEnabled = false,
                            UserName = "administracion@frro.utn.edu.ar",
                            FirstName = "Administracion",
                            LastName = "Utn"
                        });
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Company", b =>
                {
                    b.HasBaseType("ApiBolsaTrabajoUTN.API.Entities.User");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Cuit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LegalAdress")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruiterEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruiterLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruiterName")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruiterPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruiterPosition")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecruiterRelWithCompany")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sector")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Web")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Student", b =>
                {
                    b.HasBaseType("ApiBolsaTrabajoUTN.API.Entities.User");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressNum")
                        .HasColumnType("TEXT");

                    b.Property<int>("ApprovedSubjets")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Average")
                        .HasColumnType("REAL");

                    b.Property<float>("AverageWithFails")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CareerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cuil")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentCareerYear")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Curriculum")
                        .HasColumnType("BLOB");

                    b.Property<string>("Dni")
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GithubProfileURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Legajo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LinkedinProfileURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumb")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanDeEstudio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillsId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Turn")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.JobPosition", b =>
                {
                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.Career", "Career")
                        .WithMany("JobPositions")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.Company", "Company")
                        .WithMany("JobPositions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobPositionStudent", b =>
                {
                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.JobPosition", null)
                        .WithMany()
                        .HasForeignKey("JobAppliesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsWhoAppliedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApiBolsaTrabajoUTN.API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Career", b =>
                {
                    b.Navigation("JobPositions");
                });

            modelBuilder.Entity("ApiBolsaTrabajoUTN.API.Entities.Company", b =>
                {
                    b.Navigation("JobPositions");
                });
#pragma warning restore 612, 618
        }
    }
}