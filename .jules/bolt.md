## 2025-03-09 - Removing Artificial Latency and Sync EF Queries in PublicApi

**Learning:** PublicApi endpoints (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` Identity queries blocking async execution threads.
**Action:** Always remove artificial delays and ensure EF Core query evaluation uses async extensions (`ToListAsync`) to maintain high throughput and low response latency.
