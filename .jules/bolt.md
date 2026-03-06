# Bolt's Performance Journal

## 2025-05-14 - Artificial Latency and Sync Identity Calls
**Learning:** Found artificial `Task.Delay(1000)` calls in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) that were significantly slowing down API responses. Also identified synchronous `.ToList()` calls on Identity managers (`UserManager`, `RoleManager`) that could be optimized to asynchronous `.ToListAsync()` to improve scalability.
**Action:** Removed `Task.Delay` and replaced `.ToList()` with `.ToListAsync(ct)` from the `Microsoft.EntityFrameworkCore` namespace in the identified endpoints. This improves response time by ~1 second per call and avoids blocking threads during database operations.
