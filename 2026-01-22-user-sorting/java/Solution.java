import java.util.*;
import java.util.stream.*;

class User {
    String firstName;
    String lastName;
    int age;
    String email;

    User(String firstName, String lastName, int age, String email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }
}

class UserResult {
    String fullName;
    String email;

    UserResult(String fullName, String email) {
        this.fullName = fullName;
        this.email = email;
    }
}

public class Solution {
    public static List<UserResult> processUsers(List<User> users) {
        return users.stream()
                .filter(u -> u.age >= 18)
                .sorted(Comparator.comparing(u -> u.lastName))
                .map(u -> new UserResult(u.firstName + " " + u.lastName, u.email))
                .collect(Collectors.toList());
    }

    public static void main(String[] args) {
        List<User> users = List.of(
            new User("Alice", "Zuberg", 25, "alice@example.com"),
            new User("Bob", "Alpha", 17, "bob@example.com"),
            new User("Charlie", "Beta", 30, "charlie@example.com")
        );

        processUsers(users).forEach(
            u -> System.out.println(u.fullName + " - " + u.email)
        );
    }
}
