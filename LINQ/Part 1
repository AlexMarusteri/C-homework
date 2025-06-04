using System;
using System.Collections.Generic;
using System.Linq;

class Exercise22
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
    }

    public class Role
    {
        public int RoleId { get; set; }
        public string RoleDescription { get; set; }
    }

    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "FirstName1", LastName = "LastName1", Age = 25, RoleId = 1 },
            new Person { PersonId = 2, FirstName = "FirstName2", LastName = "LastName2", Age = 17, RoleId = 2 },
            new Person { PersonId = 3, FirstName = "FirstName3", LastName = "LastName3", Age = 30, RoleId = 1 },
            new Person { PersonId = 4, FirstName = "FirstName4", LastName = "LastName4", Age = 22, RoleId = 3 },
            new Person { PersonId = 5, FirstName = "FirstName5", LastName = "LastName5", Age = 60, RoleId = 2 }
        };

        List<Role> roles = new List<Role>
        {
            new Role { RoleId = 1, RoleDescription = "Leader" },
            new Role { RoleId = 2, RoleDescription = "Member" },
            new Role { RoleId = 3, RoleDescription = "BA" },
            new Role { RoleId = 4, RoleDescription = "Guest" },
            new Role { RoleId = 5, RoleDescription = "Intern" }
        };

        var over18 = people.Where(p => p.Age > 18);
        var allNames = people.Select(p => p.FirstName + " " + p.LastName);
        var role1People = people.Where(p => p.RoleId == 1);
        var twoYoungest = people.OrderBy(p => p.Age).Take(2);
        var skipTwoYoungest = people.OrderBy(p => p.Age).Skip(2);
        var peopleWithRoles = people.Join(roles, p => p.RoleId, r => r.RoleId,
            (p, r) => new { p.FirstName, p.LastName, r.RoleDescription });
        var orderedByAgeDesc = people.OrderByDescending(p => p.Age);
        var groupedByRole = people.GroupBy(p => p.RoleId);
        var personByName = people.FirstOrDefault(p => p.FirstName == "FirstName1");
        var totalLeaders = people.Count(p => roles.Any(r => r.RoleId == p.RoleId && r.RoleDescription == "Leader"));
        var hasBA = roles.Any(r => r.RoleDescription == "BA");
        var firstAge60 = people.FirstOrDefault(p => p.Age == 60);

        Console.WriteLine("People over 18:");
        foreach (var p in over18)
            Console.WriteLine($"{p.FirstName} {p.LastName}");

        Console.WriteLine("\nAll names:");
        foreach (var name in allNames)
            Console.WriteLine(name);

        Console.WriteLine("\nPeople with RoleId=1:");
        foreach (var p in role1People)
            Console.WriteLine($"{p.FirstName} {p.LastName}");

        Console.WriteLine("\nFirst two youngest:");
        foreach (var p in twoYoungest)
            Console.WriteLine($"{p.FirstName} {p.Age}");

        Console.WriteLine("\nAll but first two youngest:");
        foreach (var p in skipTwoYoungest)
            Console.WriteLine($"{p.FirstName} {p.Age}");

        Console.WriteLine("\nPeople with their roles:");
        foreach (var item in peopleWithRoles)
            Console.WriteLine($"{item.FirstName} {item.LastName} - {item.RoleDescription}");

        Console.WriteLine("\nPeople ordered by age descending:");
        foreach (var p in orderedByAgeDesc)
            Console.WriteLine($"{p.FirstName} {p.Age}");

        Console.WriteLine("\nPeople grouped by role:");
        foreach (var group in groupedByRole)
        {
            Console.WriteLine($"RoleId: {group.Key}");
            foreach (var p in group)
                Console.WriteLine($" - {p.FirstName}");
        }

        Console.WriteLine("\nPerson with FirstName1:");
        Console.WriteLine(personByName != null ? personByName.FirstName : "Not found");

        Console.WriteLine($"\nTotal people with role 'Leader': {totalLeaders}");
        Console.WriteLine($"Is there any 'BA'? {hasBA}");
        Console.WriteLine($"First person with age 60: {(firstAge60 != null ? firstAge60.FirstName : "Not found")}");
    }
}
