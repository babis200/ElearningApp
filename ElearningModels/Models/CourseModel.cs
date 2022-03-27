﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElearningModels.Models
{
    public class CourseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public string Name { get; set; }

        public List<string> Teachers { get; set; }

        public string Description { get; set; }

        public List<SubjectModel> Subjects { get; set; }

        public List<ExamModel> Exams { get; set; }

    }
}
