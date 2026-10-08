## 2025-05-18 - PublicApi Delay Removal & Async Identity Queries
**Learning:** Multiple endpoints (`UserListEndpoint`, `RoleListEndpoint`, `CatalogItemListPagedEndpoint`) in `PublicApi` contained artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` calls on EF Core `IQueryable` instances.
**Action:** Remove `Task.Delay` and convert `.ToList()` to `.ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` extension methods to significantly improve endpoint latency and prevent thread pool blocking.
