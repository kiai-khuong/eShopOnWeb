# Bolt's Performance Journal

## 2026-03-16 - [PublicApi Endpoints Latency and Threading Optimization]
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial `Task.Delay(1000)` calls used to simulate latency, and the Identity query endpoints query the DB using synchronous methods like `.ToList()`. Removing artificial delays and converting to `.ToListAsync()` significantly improves response times and thread-pool throughput.
**Action:** Removed artificial delays and converted `.ToList()` on Identity collections to `await ToListAsync(ct)` in UserListEndpoint, RoleListEndpoint, and CatalogItemListPagedEndpoint. Verified that the test suite continues to pass while execution times drop significantly.
