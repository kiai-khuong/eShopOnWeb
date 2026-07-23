# Bolt Performance Journal

## 2025-05-10 - Removing artificial delays and utilizing asynchronous queries
**Learning:** Found artificial 1-second delays (`Task.Delay(1000)`) in multiple PublicApi endpoints (`UserList`, `RoleList`, `CatalogItemListPaged`) simulating legacy/latency code, combined with synchronous Identity Entity Framework Core query operations (`.ToList()`). Removing these artificial delays and utilizing `ToListAsync` dramatically improves responsiveness and prevents thread pool starvation.
**Action:** Remove `Task.Delay` calls and convert `.ToList()` to `.ToListAsync()` under `Microsoft.EntityFrameworkCore` to ensure async query processing.
