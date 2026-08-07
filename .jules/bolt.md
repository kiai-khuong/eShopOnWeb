# Bolt's Performance Journal

## 2025-02-17 - Artificial Latency and Synchronous DB Queries in PublicApi
**Learning:** Found artificial `Task.Delay(1000)` calls simulating latency in PublicApi endpoints (UserList, RoleList, CatalogItemListPaged), which needlessly inflate response times by 1000ms. In addition, synchronous queries like `ToList()` on Identity Managers (`UserManager` and `RoleManager`) block the calling thread during database execution.
**Action:** Remove the artificial delays, import `Microsoft.EntityFrameworkCore` to enable async extensions, and replace `.ToList()` with `.ToListAsync(ct)` to make the endpoints fully asynchronous and non-blocking.
