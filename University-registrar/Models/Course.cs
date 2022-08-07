namespace University-registrar.Models
{
    public class Course
    {
        public int CousreId { get; set; }
        public string Name { get; set; }
        public int CourseNumber { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
