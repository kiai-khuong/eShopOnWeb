## 2025-05-20 - PublicApi Endpoints Artificial Delays and Synchronous Identity Queries
**Learning:** Multiple PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contain artificial 1000ms Task.Delay calls and synchronous IQueryable database calls (.ToList()). Removing Task.Delay and converting to async EF Core methods (.ToListAsync()) drastically improves endpoint latency and integration test execution time.
**Action:** Always check API endpoints for artificial delays or blocking synchronous DB calls, and switch to async EF Core methods with cancellation tokens.
