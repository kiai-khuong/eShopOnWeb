## 2025-03-25 - [Artificial Delays and Synchronous DB Calls in PublicApi]
**Learning:** Found multiple endpoints in `PublicApi` containing `await Task.Delay(1000)` and synchronous `.ToList()` calls on Identity Managers. These artificial bottlenecks significantly inflated response times and test durations.
**Action:** Remove `Task.Delay` and use `ToListAsync()` from `Microsoft.EntityFrameworkCore` to improve latency and scalability in API endpoints.
