namespace ClassFly.Core.Models;
public class Course
{
    public string Name { get; set; }
    public string Image { get; set; }
    public int MemberCount { get; set; }

    public List<Mentor> Mentors { get; set; }

}
