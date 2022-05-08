﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
  [DbContext(typeof(DataContext))]
  partial class DataContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("ProductVersion", "5.0.3")
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("Domain.About", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Description")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Title")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("About");
          });

      modelBuilder.Entity("Domain.AboutUs", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Text")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Title")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("SAboutUs");
          });

      modelBuilder.Entity("Domain.Achievement", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Description")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Photo")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Title")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Achievements");
          });

      modelBuilder.Entity("Domain.Activity", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<int>("Age")
                      .HasColumnType("int");

            b.Property<string>("Type")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Activities");
          });

      modelBuilder.Entity("Domain.AddAppointment", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<DateTime>("AppointmentDate")
                      .HasColumnType("datetime2");

            b.Property<string>("CustomerName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("DoctorName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Service")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Status")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Appointments");
          });

      modelBuilder.Entity("Domain.AppUser", b =>
          {
            b.Property<string>("Id")
                      .HasColumnType("nvarchar(450)");

            b.Property<int>("AccessFailedCount")
                      .HasColumnType("int");

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken()
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Country")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("DateOfBirth")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Email")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<bool>("EmailConfirmed")
                      .HasColumnType("bit");

            b.Property<string>("FirstName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Gender")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("LastName")
                      .HasColumnType("nvarchar(max)");

            b.Property<bool>("LockoutEnabled")
                      .HasColumnType("bit");

            b.Property<DateTimeOffset?>("LockoutEnd")
                      .HasColumnType("datetimeoffset");

            b.Property<string>("NormalizedEmail")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("NormalizedUserName")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("PasswordHash")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("PhoneNumber")
                      .HasColumnType("nvarchar(max)");

            b.Property<bool>("PhoneNumberConfirmed")
                      .HasColumnType("bit");

            b.Property<string>("Role")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("SecurityStamp")
                      .HasColumnType("nvarchar(max)");

            b.Property<bool>("TwoFactorEnabled")
                      .HasColumnType("bit");

            b.Property<string>("UserName")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.HasKey("Id");

            b.HasIndex("NormalizedEmail")
                      .HasDatabaseName("EmailIndex");

            b.HasIndex("NormalizedUserName")
                      .IsUnique()
                      .HasDatabaseName("UserNameIndex")
                      .HasFilter("[NormalizedUserName] IS NOT NULL");

            b.ToTable("AspNetUsers");
          });

      modelBuilder.Entity("Domain.BirthRaport", b =>
          {
            b.Property<int>("id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("PatientId")
                      .HasColumnType("nvarchar(450)");

            b.Property<DateTime>("birthDate")
                      .HasColumnType("Date");

            b.Property<string>("childName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("fatherName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("gender")
                      .HasColumnType("nvarchar(max)");

            b.Property<double>("weight")
                      .HasColumnType("float");

            b.HasKey("id");

            b.HasIndex("PatientId");

            b.ToTable("BirthRaports");
          });

      modelBuilder.Entity("Domain.BodyInfo", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<double>("Gjatesia")
                      .HasColumnType("float");

            b.Property<string>("GrupiGjakut")
                      .HasColumnType("nvarchar(max)");

            b.Property<int>("Mosha")
                      .HasColumnType("int");

            b.Property<double>("Pesha")
                      .HasColumnType("float");

            b.HasKey("Id");

            b.ToTable("BodyInfos");
          });

      modelBuilder.Entity("Domain.City", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Country")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Text")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Value")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Cities");
          });

      modelBuilder.Entity("Domain.Country", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Flag")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Text")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Value")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Countries");
          });

      modelBuilder.Entity("Domain.DReminder", b =>
          {
            b.Property<int>("id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<DateTime>("reminderDate")
                      .HasColumnType("Date");

            b.Property<string>("reminderTitle")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("id");

            b.ToTable("DReminders");
          });

      modelBuilder.Entity("Domain.DeathRaport", b =>
          {
            b.Property<int>("id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("causeOfDeath")
                      .HasColumnType("nvarchar(max)");

            b.Property<DateTime>("deathDate")
                      .HasColumnType("Date");

            b.HasKey("id");

            b.ToTable("DeathRaports");
          });

      modelBuilder.Entity("Domain.LabTest", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Date")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Location")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Name")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("LabTests");
          });

      modelBuilder.Entity("Domain.PAllergies", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Description")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Type")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("PAllergies");
          });

      modelBuilder.Entity("Domain.PatientHistory", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<string>("Date")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Descritpion")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("PatientHistories");
          });

      modelBuilder.Entity("Domain.Prescription", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("CustomerName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("DoctorName")
                      .HasColumnType("nvarchar(max)");

            b.Property<int>("Number")
                      .HasColumnType("int");

            b.Property<string>("RX")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Prescriptions");
          });

      modelBuilder.Entity("Domain.Procedure", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("uniqueidentifier");

            b.Property<DateTime>("Date")
                      .HasColumnType("datetime2");

            b.Property<string>("LocationOnBody")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Name")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Procedures");
          });

      modelBuilder.Entity("Domain.WorkingHour", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("From")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Name")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("To")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("WorkingHours");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
          {
            b.Property<string>("Id")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken()
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Name")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("NormalizedName")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.HasKey("Id");

            b.HasIndex("NormalizedName")
                      .IsUnique()
                      .HasDatabaseName("RoleNameIndex")
                      .HasFilter("[NormalizedName] IS NOT NULL");

            b.ToTable("AspNetRoles");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("ClaimType")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("ClaimValue")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("RoleId")
                      .IsRequired()
                      .HasColumnType("nvarchar(450)");

            b.HasKey("Id");

            b.HasIndex("RoleId");

            b.ToTable("AspNetRoleClaims");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int")
                      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            b.Property<string>("ClaimType")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("ClaimValue")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("UserId")
                      .IsRequired()
                      .HasColumnType("nvarchar(450)");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserClaims");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
          {
            b.Property<string>("LoginProvider")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("ProviderKey")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("ProviderDisplayName")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("UserId")
                      .IsRequired()
                      .HasColumnType("nvarchar(450)");

            b.HasKey("LoginProvider", "ProviderKey");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserLogins");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
          {
            b.Property<string>("UserId")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("RoleId")
                      .HasColumnType("nvarchar(450)");

            b.HasKey("UserId", "RoleId");

            b.HasIndex("RoleId");

            b.ToTable("AspNetUserRoles");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
          {
            b.Property<string>("UserId")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("LoginProvider")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("Name")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("Value")
                      .HasColumnType("nvarchar(max)");

            b.HasKey("UserId", "LoginProvider", "Name");

            b.ToTable("AspNetUserTokens");
          });

      modelBuilder.Entity("Domain.Doctor", b =>
          {
            b.HasBaseType("Domain.AppUser");

            b.Property<string>("Address")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("BloodGroup")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Degree")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Department")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Designation")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Specialist")
                      .HasColumnType("nvarchar(max)");

            b.ToTable("Doctors");
          });

      modelBuilder.Entity("Domain.Patient", b =>
          {
            b.HasBaseType("Domain.AppUser");

            b.Property<string>("BloodGroup")
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Disease")
                      .HasColumnType("nvarchar(max)");

            b.ToTable("Patients");
          });

      modelBuilder.Entity("Domain.BirthRaport", b =>
          {
            b.HasOne("Domain.Patient", "Patients")
                      .WithMany("BirthRaports")
                      .HasForeignKey("PatientId");

            b.Navigation("Patients");
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
            b.HasOne("Domain.AppUser", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
          {
            b.HasOne("Domain.AppUser", null)
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

            b.HasOne("Domain.AppUser", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
          {
            b.HasOne("Domain.AppUser", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Domain.Doctor", b =>
          {
            b.HasOne("Domain.AppUser", null)
                      .WithOne()
                      .HasForeignKey("Domain.Doctor", "Id")
                      .OnDelete(DeleteBehavior.ClientCascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Domain.Patient", b =>
          {
            b.HasOne("Domain.AppUser", null)
                      .WithOne()
                      .HasForeignKey("Domain.Patient", "Id")
                      .OnDelete(DeleteBehavior.ClientCascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Domain.Patient", b =>
          {
            b.Navigation("BirthRaports");
          });
#pragma warning restore 612, 618
    }
  }
}
