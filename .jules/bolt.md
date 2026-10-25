## 2025-05-18 - Artificial Latency Delays in PublicApi Endpoints
**Learning:** PublicApi endpoints (such as CatalogItemListPaged) contained artificial `Task.Delay(1000, ct)` calls designed to simulate network latency, unnecessarily increasing endpoint response times by 1 second per request.
**Action:** Remove artificial delay calls in API endpoints to eliminate redundant latency while ensuring clear performance comments document the modification.
