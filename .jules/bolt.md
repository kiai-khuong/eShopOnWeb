## 2025-05-18 - Artificial Latency Delays in Public API Endpoints
**Learning:** Certain endpoints in `PublicApi` (e.g. `CatalogItemListPagedEndpoint`) contained hardcoded artificial `Task.Delay(1000)` calls simulating latency. Removing these delays immediately cuts endpoint latency by 1s and significantly speeds up API test execution.
**Action:** Audit API endpoints for intentional or leftover `Task.Delay` calls and remove them when optimizing response performance.
