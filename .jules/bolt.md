## 2025-05-15 - [Initial Performance Audit & Optimizations]
**Learning:** Artificial latency (`Task.Delay`) and synchronous database operations in PublicApi endpoints significantly impact response times. Additionally, missing `.AsNoTracking()` in read-only specifications causes unnecessary overhead in Entity Framework Core.
**Action:** Removed artificial delays, converted Identity manager operations to use `ToListAsync(ct)`, and applied `.AsNoTracking()` to UI-facing specifications.

**Optimizations implemented:**
- Removed `Task.Delay(1000)` from `RoleListEndpoint`, `CatalogItemListPagedEndpoint`, and `UserListEndpoint`.
- Updated `RoleListEndpoint` and `UserListEndpoint` to use asynchronous EF Core methods.
- Added `.AsNoTracking()` to `CatalogFilterSpecification` and `CatalogFilterPaginatedSpecification`.
