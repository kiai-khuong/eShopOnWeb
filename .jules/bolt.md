# Bolt's Performance Journal

## 2025-05-18 - Eliminating Artificial Latency in PublicApi Endpoints
**Learning:** Certain PublicApi endpoints (such as `CatalogItemListPagedEndpoint`) contain hardcoded `await Task.Delay(1000, ct);` statements that artificially increase request latency and delay integration test runs by over 10 seconds.
**Action:** Remove hardcoded delay calls from API endpoints to optimize throughput, reduce user-facing latency, and significantly speed up test suites.
