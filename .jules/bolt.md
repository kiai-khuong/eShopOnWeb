## 2025-05-14 - [Artificial Delays in PublicApi Endpoints]
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contain artificial `Task.Delay(1000)` calls, likely to simulate latency for UI testing. Removing these significantly improves response times and reduces test execution duration (from ~15s to ~5s in PublicApiIntegrationTests).
**Action:** Always check for and remove simulated delays in PublicApi endpoints when optimizing for performance.

## 2025-05-14 - [AsNoTracking in Specifications]
**Learning:** Read-only queries in eShopOnWeb often use the Specification pattern. Adding `Query.AsNoTracking()` to specifications used by UI services (like catalog filters) reduces memory overhead and improves performance without breaking functionality.
**Action:** Apply `AsNoTracking()` to specifications used exclusively for read-only operations.
