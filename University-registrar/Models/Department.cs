using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
    public class Department
    {
        public Department()
        {
            this.JoinEntities = new HashSet<DepartmentCourse>();
            this.JoinStudentDepartment = new HashSet<StudentDepartment>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DepartmentCourse> JoinEntities { get; set; }
        public virtual ICollection<StudentDepartment> JoinStudentDepartment { get; set; }
    }
}
