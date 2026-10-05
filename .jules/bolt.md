# Bolt Performance Journal

## 2025-05-18 - Latency Overhead in PublicApi Catalog Endpoint
**Learning:** `CatalogItemListPagedEndpoint` contained an artificial `Task.Delay(1000, ct)` call that added 1000ms latency to every paged catalog query.
**Action:** Remove artificial `Task.Delay` calls in API endpoints to dramatically improve response latency and throughput.
