## 2026-04-19 - Removed artificial delays in PublicApi endpoints
**Learning:** Found artificial 1000ms Task.Delay calls in several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) likely intended to simulate latency. Removing them significantly improves response times and test suite performance.
**Action:** Always check for artificial delays when profiling for quick performance wins. Also, convert synchronous database calls like .ToList() to .ToListAsync() when using Entity Framework in async methods.
