## 2025-05-10 - Artificial Delays in Public API Endpoints
**Learning:** PublicApi endpoints like `CatalogItemListPagedEndpoint` contained artificial `Task.Delay(1000, ct)` calls simulating network latency, adding a mandatory 1-second delay to every paged catalog request.
**Action:** Remove hardcoded `Task.Delay` calls in endpoints to immediately eliminate 1s of baseline latency per request.
