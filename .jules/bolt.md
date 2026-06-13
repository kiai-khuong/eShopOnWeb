## 2025-05-14 - Artificial delays and sync I/O in PublicApi
**Learning:** The PublicApi project contained artificial 1-second delays (Task.Delay(1000)) in several endpoints, likely intended to simulate network latency during development. Additionally, UserManager and RoleManager queries were using synchronous .ToList(), which blocks threads during DB I/O.
**Action:** Removed artificial delays and converted synchronous .ToList() calls to await ...ToListAsync(ct) using Microsoft.EntityFrameworkCore. This reduced PublicApiIntegrationTests execution time from 17s to 5s.
