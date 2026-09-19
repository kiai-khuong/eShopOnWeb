## 2025-03-03 - Artificial Latency in PublicApi Endpoints

**Learning:** `CatalogItemListPagedEndpoint` (along with select other PublicApi endpoints) contained an artificial `Task.Delay(1000, ct)` call that added 1000ms of latency per request. Removing this delay directly improves endpoint response times by 1 second without compromising any functionality.
**Action:** Always check for artificial delays or synchronous blocking in API endpoints before attempting complex architectural refactoring.
