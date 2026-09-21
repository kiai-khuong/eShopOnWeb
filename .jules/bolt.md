## 2025-05-18 - Artificial Latency in PublicApi Endpoints
**Learning:** Several endpoints in `PublicApi` (such as `CatalogItemListPagedEndpoint`) contain hardcoded `Task.Delay(1000)` calls that add artificial 1s latency per request.
**Action:** Remove `Task.Delay` calls in API endpoints to eliminate unneeded latency and improve test execution time.
