﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class StudentCourse
    {

        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; } = null!;

       
        public Course Course { get; set; }
      
    }
}
