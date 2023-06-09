﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }

        public int TeacherAge { get; set; }

        public Subject Subject { get; set; } 

    }
}
