## 2025-05-18 - Removing Artificial Latency Delays in API Endpoints
**Learning:** `CatalogItemListPagedEndpoint` contained an artificial `Task.Delay(1000, ct)` call that added 1000ms latency to every paged catalog query.
**Action:** Remove unnecessary artificial delays in production endpoints to minimize response latency and maximize throughput.
