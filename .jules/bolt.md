## 2025-05-18 - Removing artificial delays and non-blocking Identity queries in PublicApi

**Learning:** `CatalogItemListPagedEndpoint`, `UserListEndpoint`, and `RoleListEndpoint` contained artificial `Task.Delay(1000)` calls and synchronous EF Core blocking calls (`.ToList()`). Removing these delays and switching Identity manager queries to `ToListAsync()` reduced API response times and dropped `PublicApiIntegrationTests` execution time from ~18s to ~4s.
**Action:** When auditing ASP.NET Core endpoints, search for `Task.Delay` and synchronous EF Core calls (`.ToList()`), and replace them with non-blocking `ToListAsync(ct)` calls.
