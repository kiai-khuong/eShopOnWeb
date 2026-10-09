# Bolt Performance Journal

## 2025-05-18 - Identity Management Endpoint Latency
**Learning:** `UserListEndpoint` and `RoleListEndpoint` contained artificial 1-second delay calls (`Task.Delay(1000, ct)`) and synchronous Entity Framework queries (`.ToList()`).
**Action:** Remove artificial `Task.Delay` and convert `.ToList()` to async `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` extension methods to significantly reduce response latency.
