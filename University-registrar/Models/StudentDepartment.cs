namespace UniversityRegistrar.Models
{
    public class StudentDepartment
    {
        public int StudentDepartmentId { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Department Department { get; set; }
    }
}
