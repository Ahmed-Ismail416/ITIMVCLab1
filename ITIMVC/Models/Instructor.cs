public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public string Image { get; set; }
    public string Hd { get; set; } // احتمال يكون Head Department
    public string Address { get; set; }

    // Foreign Key
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    // Relations
    public ICollection<Course> Courses { get; set; }
}
