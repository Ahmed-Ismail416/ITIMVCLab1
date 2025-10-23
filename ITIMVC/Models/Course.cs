public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Topic { get; set; }
    public int Degree { get; set; }
    public int MinDegree { get; set; }

    // Relations
    public ICollection<Student> Students { get; set; }
    public ICollection<Instructor> Instructors { get; set; }

    // Extra property (from diagram)
    public decimal RateHour { get; set; }
}
