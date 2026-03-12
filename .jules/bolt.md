## 2025-05-22 - Removing artificial latency and improving asynchrony
**Learning:** Some PublicApi endpoints contained `await Task.Delay(1000, ct);` which artificially slowed down responses. Additionally, `RoleManager` and `UserManager` queries were using synchronous `.ToList()`, which can block threads under load.
**Action:** Always check for `Task.Delay` in endpoints and ensure all I/O operations (like database queries) use asynchronous methods like `ToListAsync(ct)`.
