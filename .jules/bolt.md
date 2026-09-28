## 2025-05-15 - Artificial Delays in PublicApi Endpoints
**Learning:** PublicApi endpoints like `CatalogItemListPagedEndpoint` contain artificial `Task.Delay(1000, ct)` calls that inject an intentional 1-second latency bottleneck per request.
**Action:** Remove `Task.Delay` calls to significantly reduce API latency and speed up integration test suite execution.
