## 2025-05-18 - Eliminating Artificial Delays in PublicApi Endpoints
**Learning:** PublicApi endpoints contained artificial `Task.Delay(1000, ct)` calls likely used to simulate network latency. Removing this delay from `CatalogItemListPagedEndpoint` eliminates a 1000ms delay per request and reduces integration test execution time significantly (~6s reduction in suite time).
**Action:** Inspect remaining endpoints with simulated latency (`UserListEndpoint`, `RoleListEndpoint`) for future isolated performance optimizations while keeping PRs focused to single domain areas.
