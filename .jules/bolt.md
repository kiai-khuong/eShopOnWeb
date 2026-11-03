## 2025-05-15 - Elimination of Simulated Latency in PublicApi Endpoints
**Learning:** PublicApi endpoints such as `CatalogItemListPagedEndpoint` contained artificial `Task.Delay(1000, ct)` calls designed to simulate network latency, which imposed a mandatory 1-second overhead per request and slowed down test suite execution significantly.
**Action:** Remove artificial `Task.Delay` calls in API endpoints to eliminate unnecessary response latency, boost throughput, and speed up integration test suites.
