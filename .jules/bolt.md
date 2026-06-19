## 2026-06-19 - [Optimizing Identity and Catalog Endpoints]
**Learning:** Identity Manager properties (UserManager.Users, RoleManager.Roles) are IQueryable, allowing for async materialization using ToListAsync(ct). Artificial Task.Delay calls (1000ms) are used in PublicApi endpoints to simulate latency, significantly impacting performance.
**Action:** Remove artificial Task.Delay and convert synchronous materialization (.ToList()) to asynchronous (.ToListAsync(ct)) in Identity endpoints by adding 'using Microsoft.EntityFrameworkCore;'.
