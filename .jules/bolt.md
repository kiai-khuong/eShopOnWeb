## 2025-05-15 - Async Operations with Identity Managers
**Learning:** In the `PublicApi` project, `UserManager<T>` and `RoleManager<T>` expose `IQueryable` properties (like `.Users` and `.Roles`). To perform asynchronous database operations on these, you must include `using Microsoft.EntityFrameworkCore;` to access extension methods like `ToListAsync()`.
**Action:** Always ensure `Microsoft.EntityFrameworkCore` is imported when working with Identity managers to avoid accidental blocking synchronous calls.
