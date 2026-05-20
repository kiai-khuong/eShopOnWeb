## 2026-05-20 - Remove artificial delays and fix sync-over-async in PublicApi
**Learning:** The codebase contains artificial `Task.Delay(1000, ct)` calls in PublicApi endpoints, likely to simulate latency. Additionally, some Identity Manager queries were using synchronous `.ToList()` instead of `.ToListAsync(ct)`.
**Action:** Always check for `Task.Delay` and synchronous materialization of `IQueryable` in new or existing endpoints.
