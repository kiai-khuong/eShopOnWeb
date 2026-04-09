## 2025-05-15 - [Remove artificial delays and optimize async operations in PublicApi]
**Learning:** Artificial `Task.Delay` calls and synchronous `.ToList()` operations in `PublicApi` endpoints were causing significant latency and slowing down integration tests. Removing these and switching to `ToListAsync(ct)` reduced `PublicApiIntegrationTests` execution time from ~16s to ~6s.
**Action:** Always check for `Task.Delay` in endpoints and prefer `ToListAsync()` or other async equivalents when working with `IQueryable` in EF Core to ensure non-blocking execution.
