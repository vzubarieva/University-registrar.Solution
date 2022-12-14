using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.JoinEntities = new HashSet<CourseStudent>();
            this.JoinStudentDepartment = new HashSet<StudentDepartment>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string DateOfEnrollment { get; set; }
        public virtual ICollection<CourseStudent> JoinEntities { get; }
        public virtual ICollection<StudentDepartment> JoinStudentDepartment { get; }
    }
}
