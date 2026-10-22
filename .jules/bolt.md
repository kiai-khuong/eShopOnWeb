## 2025-02-28 - Artificial Delays in PublicApi Endpoints

**Learning:** `CatalogItemListPagedEndpoint` contained an artificial `Task.Delay(1000, ct)` call that added 1000ms latency to every paged catalog query.
**Action:** Remove artificial delay calls in API endpoints to dramatically decrease endpoint response times without breaking contracts.
