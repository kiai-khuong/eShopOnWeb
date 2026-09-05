# Bolt's Performance Journal

## 2025-05-18 - Latency bottleneck in PublicApi endpoints
**Learning:** Artificial `Task.Delay` calls were found in PublicApi endpoints (such as `CatalogItemListPagedEndpoint`), introducing artificial latency (1000ms per call).
**Action:** Remove artificial delays and optimize database queries to improve API response time and test execution speed.
