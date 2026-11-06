## 2025-05-18 - Eliminating artificial delay and using async Identity queries in PublicApi
**Learning:** PublicApi identity endpoints (UserListEndpoint and RoleListEndpoint) contained an artificial 1000ms delay and performed synchronous database queries via LINQ `.ToList()`.
**Action:** Remove `Task.Delay` and utilize EF Core's `ToListAsync(ct)` for non-blocking asynchronous queries to significantly improve API throughput and response latency.
