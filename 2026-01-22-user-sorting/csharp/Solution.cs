using System;
using System.Collections.Generic;
using System.Linq;

record User(string FirstName, string LastName, int Age, string Email);

record UserResult(string FullName, string Email);

class Solution {
    public static List<UserResult> ProcessUsers(List<User> users) {
        return users
            .Where(u => u.Age >= 18)
            .OrderBy(u => u.LastName)
            .Select(u => new UserResult(u.FirstName + " " + u.LastName, u.Email))
            .ToList();
    }

    static void Main(string[] args) {
        var users = new List<User> {
            new User("Alice", "Zuberg", 25, "alice@example.com"),
            new User("Bob", "Alpha", 17, "bob@example.com"),
            new User("Charlie", "Beta", 30, "charlie@example.com")
        };

        foreach (var user in ProcessUsers(users)) {
            Console.WriteLine($"{user.FullName} - {user.Email}");
        }
    }
}
