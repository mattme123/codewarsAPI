﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codeWarsAPI.DataAccess;

namespace codeWarsAPI.Migrations
{
    [DbContext(typeof(CodewarsContext))]
    partial class CodewarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("codeWarsAPI.Models.Cohort", b =>
                {
                    b.Property<int>("CohortId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Year");

                    b.HasKey("CohortId");

                    b.ToTable("Cohorts");
                });

            modelBuilder.Entity("codeWarsAPI.Models.Kata", b =>
                {
                    b.Property<int>("KataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompletedDate");

                    b.Property<bool>("IsCompleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("KataLink")
                        .IsRequired();

                    b.Property<string>("KataName")
                        .IsRequired();

                    b.Property<DateTime>("ProposedDate");

                    b.Property<int?>("StudentId");

                    b.Property<int?>("StudentId1");

                    b.HasKey("KataId");

                    b.HasIndex("StudentId");

                    b.HasIndex("StudentId1");

                    b.ToTable("Katas");
                });

            modelBuilder.Entity("codeWarsAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CohortFK");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("Username");

                    b.HasKey("StudentId");

                    b.HasIndex("CohortFK");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("codeWarsAPI.Models.Kata", b =>
                {
                    b.HasOne("codeWarsAPI.Models.Student")
                        .WithMany("KatasCompleted")
                        .HasForeignKey("StudentId");

                    b.HasOne("codeWarsAPI.Models.Student")
                        .WithMany("KatasProposed")
                        .HasForeignKey("StudentId1");
                });

            modelBuilder.Entity("codeWarsAPI.Models.Student", b =>
                {
                    b.HasOne("codeWarsAPI.Models.Cohort", "Cohort")
                        .WithMany()
                        .HasForeignKey("CohortFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
