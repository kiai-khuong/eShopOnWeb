# Bolt Journal

## 2025-05-15 - Artificial Delays and Sync Identity Queries in PublicApi
**Learning:** PublicApi endpoints (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) contained 1000ms `Task.Delay` calls and synchronous `ToList()` queries on EF Core Identity DbSets, causing ~16s test execution times and high API latency.
**Action:** Remove `Task.Delay` calls and switch `ToList()` to `ToListAsync()` to make API responses instantaneous and avoid blocking thread pool threads.
