# Bolt's Journal - Critical Learnings Only

## 2025-05-23 - Artificial Delays and Async Efficiency
**Learning:** Removing artificial `Task.Delay` calls and converting synchronous `.ToList()` to asynchronous `.ToListAsync()` in PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) significantly reduces response latency and test execution time. The `PublicApiIntegrationTests` execution time was reduced from ~16s down to ~6s (a 60%+ reduction).
**Action:** Always check for `Task.Delay` and synchronous I/O operations in high-traffic endpoints and replace them with fully asynchronous alternatives.
