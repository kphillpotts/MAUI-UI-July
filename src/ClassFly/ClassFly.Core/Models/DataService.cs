namespace ClassFly.Core.Models;

public class DataService
{
    public static List<Course> GetCourses() => new()
    {
        new Course{Name = "Guitar", Mentors = new ()
        {
            new Mentor {Name = "Scarlett", FollowerCount = 70},
            new Mentor {Name = "Jhony", FollowerCount = 150},
            new Mentor {Name = "Linda", FollowerCount = 30},
        }},
        new Course{Name = "Saxophone", Mentors = new ()
        {
            new Mentor {Name = "Scarlett", FollowerCount = 70},
            new Mentor {Name = "Jhony", FollowerCount = 150},
            new Mentor {Name = "Linda", FollowerCount = 30},
        }},
        new Course{Name = "Drums", Mentors = new ()
        {
            new Mentor {Name = "Scarlett", FollowerCount = 70},
            new Mentor {Name = "Jhony", FollowerCount = 150},
            new Mentor {Name = "Linda", FollowerCount = 30},
        }},
        new Course{Name = "Piano", Mentors = new ()
        {
            new Mentor {Name = "Scarlett", FollowerCount = 70},
            new Mentor {Name = "Jhony", FollowerCount = 150},
            new Mentor {Name = "Linda", FollowerCount = 30},
        }},
        new Course{Name = "Double Bass", Mentors = new ()
        {
            new Mentor {Name = "Scarlett", FollowerCount = 70},
            new Mentor {Name = "Jhony", FollowerCount = 150},
            new Mentor {Name = "Linda", FollowerCount = 30},
        }},
    };
}
