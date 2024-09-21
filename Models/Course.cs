using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();





    }
}
