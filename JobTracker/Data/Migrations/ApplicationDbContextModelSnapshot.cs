﻿// <auto-generated />
using JobTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JobTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobTracker.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("PhoneNumber");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("JobTracker.Models.CompanyContact", b =>
                {
                    b.Property<int>("CompanyContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<int>("ContactId");

                    b.HasKey("CompanyContactId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ContactId");

                    b.ToTable("CompanyContact");
                });

            modelBuilder.Entity("JobTracker.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("PhoneNum");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("JobTracker.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("JobDesc")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<int>("StatusId");

                    b.HasKey("JobId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("JobTracker.Models.JobContact", b =>
                {
                    b.Property<int>("JobContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactId");

                    b.Property<int>("JobId");

                    b.HasKey("JobContactId");

                    b.HasIndex("ContactId");

                    b.HasIndex("JobId");

                    b.ToTable("JobContact");
                });

            modelBuilder.Entity("JobTracker.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JobStatus")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("JobTracker.Models.CompanyContact", b =>
                {
                    b.HasOne("JobTracker.Models.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobTracker.Models.Contact", "Contact")
                        .WithMany("CompanyContacts")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobTracker.Models.Job", b =>
                {
                    b.HasOne("JobTracker.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobTracker.Models.Status", "Status")
                        .WithMany("Jobs")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobTracker.Models.JobContact", b =>
                {
                    b.HasOne("JobTracker.Models.Contact", "Contact")
                        .WithMany("JobContacts")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobTracker.Models.Job", "Job")
                        .WithMany("Contacts")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
