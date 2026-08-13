# Bolt Performance Journal

## 2025-02-17 - Artificial Delays in PublicApi Endpoints
**Learning:** Found artificial 1000ms delays (Task.Delay) in key PublicApi endpoints (CatalogItemListPaged, UserList, RoleList), probably introduced to simulate backend latency or test UI spinners. These severely bottleneck API throughput and response times.
**Action:** Remove unnecessary artificial delays to immediately improve latency and thread pool utilization in list-paged API requests.
