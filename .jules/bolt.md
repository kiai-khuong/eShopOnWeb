## 2025-05-14 - Optimization of PublicApi Endpoints
**Learning:** Artificial Task.Delay calls (1000ms) were identified as a significant performance bottleneck in list endpoints. Converting synchronous .ToList() to asynchronous .ToListAsync(ct) on IQueryable properties of Identity managers (UserManager, RoleManager) improves scalability.
**Action:** Always check for artificial delays and sync-over-async patterns in API endpoints when profiling for performance.
