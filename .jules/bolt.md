## 2026-05-07 - Artificial delays and sync-over-async in PublicApi
**Learning:** Found 1000ms artificial delays in several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) used to simulate latency. Also identified synchronous .ToList() calls on IQueryable properties of Identity managers (UserManager, RoleManager).
**Action:** Always check for Task.Delay in sample/template codebases and convert synchronous list conversions to await ...ToListAsync(ct) using Microsoft.EntityFrameworkCore to improve throughput and response times.
