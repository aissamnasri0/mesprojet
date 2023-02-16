namespace School.Models
{
    public class Student
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Course>? courses { get;set; }
    }
}
