def get_nth(n):
    if n < 0:
        raise ValueError("n must be non-negative")
    
    if n == 0:
        return 0
    if n == 1:
        return 1

    prev = 0
    curr = 1

    for i in range(2, n + 1):
        prev, curr = curr, prev + curr

    return curr
