## 2025-05-14 - [Artificial Delays and Async Queries]
**Learning:** Found 1000ms artificial delays in several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) designed to simulate latency. Additionally, some Identity-related queries were using synchronous .ToList() which blocks threads.
**Action:** Removed (commented out) the delays and converted Identity queries to .ToListAsync(ct) using Microsoft.EntityFrameworkCore. This reduced PublicApiIntegrationTests duration from ~15s to ~8s.
