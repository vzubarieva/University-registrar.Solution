using System.Collections.Generic;

namespace University-registrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Course = new HashSet<Course>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string DateOfEnrollment { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
    }
}
