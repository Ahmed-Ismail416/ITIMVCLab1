namespace ITIMVC.Models;
public class Department
{
    public int DeptId { get; set; }
    public string Name { get; set; }
    public string Manager { get; set; }
    public string Location { get; set; }
    public string Branches { get; set; } // ممكن تخليها Enum بعدين

    // Relations
    public ICollection<Student> Students { get; set; }
    public ICollection<Instructor> Instructors { get; set; }
}
