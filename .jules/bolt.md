## 2025-02-18 - Removing Artificial Endpoint Latency in PublicApi

**Learning:** `CatalogItemListPagedEndpoint` contained an artificial 1000ms delay (`await Task.Delay(1000, ct)`) introduced during development/testing. Removing this delay improves endpoint throughput and reduces latency by ~1000ms per request.
**Action:** When auditing API endpoint performance, scan for simulated latency patterns like `Task.Delay` and remove them to ensure optimal real-world endpoint latency.
