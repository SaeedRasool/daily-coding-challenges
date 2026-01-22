def process_users(users):
    filtered = [u for u in users if u["age"] >= 18]
    sorted_users = sorted(filtered, key=lambda u: u["lastName"])
    return [
        {
            "fullName": f"{u['firstName']} {u['lastName']}",
            "email": u["email"]
        }
        for u in sorted_users
    ]


users = [
    {"firstName": "Alice", "lastName": "Zuberg", "age": 25, "email": "alice@example.com"},
    {"firstName": "Bob", "lastName": "Alpha", "age": 17, "email": "bob@example.com"},
    {"firstName": "Charlie", "lastName": "Beta", "age": 30, "email": "charlie@example.com"}
]

for user in process_users(users):
    print(user)
