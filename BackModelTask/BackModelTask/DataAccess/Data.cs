using BackModelTask.Models;
using System.Collections.Generic;

namespace BackModelTask.DataAccess
{
    public static class Data
    {
        public static List<Group> groups =new List<Group>() { 
            new Group { Id = 1, Name = "P100" },
            new Group { Id = 2, Name = "P200" },
            new Group { Id = 3, Name = "P300" },
            new Group { Id = 4, Name = "P400" },
            new Group { Id = 5, Name = "P500" },
        };

        public static List<Student> students = new List<Student>() {
            new Student { id = 1, FullName = "Akif", Point =100 },
            new Student { id = 2, FullName = "Mikayil", Point = 90 },
            new Student { id = 3, FullName = "Sergey",Point = 80 },
            new Student { id = 4, FullName = "Ronaldo",Point = 70 },
            new Student { id = 5, FullName = "Ahad",Point = 60 },
        };

    }
}
