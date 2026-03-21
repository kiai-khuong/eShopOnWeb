## 2026-03-21 - Removing Artificial Latency in PublicApi
**Learning:** The PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial 1s delays (`Task.Delay(1000)`) presumably for testing or simulating slow networks. These significantly bloat test execution time and real-world latency.
**Action:** Always check for and remove artificial delays in API endpoints. Removing them reduced PublicApi integration test suite time by ~60%.

## 2026-03-21 - Asynchronous Identity Manager Operations
**Learning:** Using `.Users.ToList()` or `.Roles.ToList()` on Identity managers blocks the calling thread. While the managers themselves are often used asynchronously, the IQueryable projection needs explicit async termination.
**Action:** Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to ensure non-blocking database operations when listing users or roles.

## 2026-03-21 - No-Tracking for Read-Only Specifications
**Learning:** The Specification pattern used in this codebase (Ardalis.Specification) supports `Query.AsNoTracking()`. Applying this to read-only catalog specifications reduces EF Core's tracking overhead.
**Action:** Use `Query.AsNoTracking()` in specifications intended for UI display or read-only list operations.
