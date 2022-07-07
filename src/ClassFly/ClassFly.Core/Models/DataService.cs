namespace ClassFly.Core.Models;

public class DataService
{
    public static List<Course> GetCourses() => new()
    {
        new Course
        {
            Name = "Guitar",
            MemberCount = 45,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }},
        new Course
        {
            Name = "Saxophone",
            MemberCount = 14,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
        new Course{Name = "Drums",
            MemberCount = 19,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
        new Course{Name = "Piano",
            MemberCount = 27,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
        new Course
        {
            Name = "Double Bass",
            MemberCount = 100,
            Mentors = new ()
            {   
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
    };
}
