using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.JoinEntities = new HashSet<CourseStudent>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string DateOfEnrollment { get; set; }
        public virtual ICollection<CourseStudent> JoinEntities { get; }
    }
}
