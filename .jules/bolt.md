## 2026-07-02 - Removed artificial delays and optimized Identity queries
**Learning:** Removing artificial 1-second delays and converting synchronous '.ToList()' to 'ToListAsync()' in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) significantly improves response times and reduces test suite execution time (from ~15s to ~4s).
**Action:** Always check for artificial 'Task.Delay' calls and synchronous list materialization on IQueryable properties in this codebase.
