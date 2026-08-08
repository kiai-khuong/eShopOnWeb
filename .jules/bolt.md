# Bolt's Performance Journal

## 2025-01-21 - Artificial Delays in PublicApi Endpoints
**Learning:** Multiple PublicApi endpoints (such as `UserListEndpoint`, `RoleListEndpoint`, and `CatalogItemListPagedEndpoint`) contain artificial `Task.Delay(1000, ct)` calls, which simulate latency but severely slow down both end-user performance and integration/functional test suite execution times. Removing these and switching synchronous Identity/EF queries to `ToListAsync` drastically improves response times and test suite speeds.
**Action:** Remove the artificial delays and optimize any synchronous LINQ operations on database queries to use `ToListAsync` async methods, ensuring `Microsoft.EntityFrameworkCore` is imported. Keep PRs focused on a single domain to avoid rejection for bundling unrelated conceptual changes.
