# Bolt Performance Journal

## 2025-03-10 - Eliminate Latency Delays and Async Conversion in PublicApi Endpoints
**Learning:** Found artificial `Task.Delay(1000)` calls in multiple PublicApi endpoints (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) along with synchronous `.ToList()` calls on EF-backed managers (`UserManager`, `RoleManager`). Removing artificial delays and transitioning to native `ToListAsync()` asynchronous queries dramatically improves API performance and integration test times.
**Action:** Always inspect endpoints for artificial latency delays and non-async database/manager calls, converting them to optimized async equivalents where possible.
