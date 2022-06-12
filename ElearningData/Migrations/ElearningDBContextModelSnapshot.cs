﻿// <auto-generated />
using System;
using ElearningData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElearningData.Migrations
{
    [DbContext(typeof(ElearningDBContext))]
    partial class ElearningDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("ElearningModels.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teachers")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ElearningModels.ExamModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CourseModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grades")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SubjectModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseModelId");

                    b.HasIndex("SubjectModelId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ElearningModels.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExamModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FreeFormId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MultipleChoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QType")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TrueFalseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExamModelId");

                    b.HasIndex("FreeFormId");

                    b.HasIndex("MatchId");

                    b.HasIndex("MultipleChoiceId");

                    b.HasIndex("TrueFalseId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("ElearningModels.Questions.FreeFormQModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FreeFormQs");
                });

            modelBuilder.Entity("ElearningModels.Questions.MatchQModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Choices")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MatchQs");
                });

            modelBuilder.Entity("ElearningModels.Questions.MultipleChoiceQModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Answer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Choices")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MultipleChoiceQs");
                });

            modelBuilder.Entity("ElearningModels.Questions.TrueFalseQModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Answer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TrueFalseQs");
                });

            modelBuilder.Entity("ElearningModels.SubjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CourseModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Resources")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseModelId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ElearningModels.ExamModel", b =>
                {
                    b.HasOne("ElearningModels.CourseModel", null)
                        .WithMany("Exams")
                        .HasForeignKey("CourseModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ElearningModels.SubjectModel", null)
                        .WithMany("Exams")
                        .HasForeignKey("SubjectModelId");
                });

            modelBuilder.Entity("ElearningModels.Question", b =>
                {
                    b.HasOne("ElearningModels.ExamModel", null)
                        .WithMany("Questions")
                        .HasForeignKey("ExamModelId");

                    b.HasOne("ElearningModels.Questions.FreeFormQModel", "FreeForm")
                        .WithMany()
                        .HasForeignKey("FreeFormId");

                    b.HasOne("ElearningModels.Questions.MatchQModel", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");

                    b.HasOne("ElearningModels.Questions.MultipleChoiceQModel", "MultipleChoice")
                        .WithMany()
                        .HasForeignKey("MultipleChoiceId");

                    b.HasOne("ElearningModels.Questions.TrueFalseQModel", "TrueFalse")
                        .WithMany()
                        .HasForeignKey("TrueFalseId");

                    b.Navigation("FreeForm");

                    b.Navigation("Match");

                    b.Navigation("MultipleChoice");

                    b.Navigation("TrueFalse");
                });

            modelBuilder.Entity("ElearningModels.SubjectModel", b =>
                {
                    b.HasOne("ElearningModels.CourseModel", null)
                        .WithMany("Subjects")
                        .HasForeignKey("CourseModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElearningModels.CourseModel", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("ElearningModels.ExamModel", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ElearningModels.SubjectModel", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}