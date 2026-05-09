## 2025-05-14 - Artificial Latency in PublicApi Endpoints
**Learning:** Several endpoints in `src/PublicApi` (e.g., `CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) contained explicit `await Task.Delay(1000, ct);` calls. These were likely added to simulate network latency during development but significantly impact production performance and CI/CD test duration.
**Action:** Always check for and remove artificial `Task.Delay` calls in API endpoints during performance optimization tasks. Removing them reduced `PublicApiIntegrationTests` execution time by over 50%.
