## 2026-05-24 - Artificial Delays and Synchronous Identity Queries
**Learning:** Found multiple PublicApi endpoints (Catalog, Roles, Users) with 1000ms artificial delays and synchronous `.ToList()` calls on Identity managers. Removing these and using `ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` significantly reduces response time and improves scalability.
**Action:** Always search for `Task.Delay` and `.ToList()` in new endpoints to identify "simulated latency" or blocking I/O anti-patterns.
