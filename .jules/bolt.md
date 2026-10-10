## 2025-05-20 - Removal of Artificial Latency in CatalogItemListPagedEndpoint
**Learning:** `CatalogItemListPagedEndpoint` contained an artificial `Task.Delay(1000, ct)` simulation that injected 1000ms latency into every catalog items query.
**Action:** Remove artificial delay calls in public endpoints to improve response times and accelerate test executions.
