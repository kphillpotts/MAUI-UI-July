namespace ClassFly.Core.Models;

public class DataService
{
    public static List<Course> GetCourses() => new()
    {
        new Course
        {
            Name = "Guitar",
            Image = "guitar.png",
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
            Image = "saxophone.png",
            MemberCount = 14,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
        new Course{Name = "Drums",
            Image = "drums.png",
            MemberCount = 19,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", FollowerCount = 70},
                new Mentor {Name = "Jhony", FollowerCount = 150},
                new Mentor {Name = "Linda", FollowerCount = 30},
            }
        },
        new Course{Name = "Piano",
            Image = "piano.png",
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
            Image = "bass.png",
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
