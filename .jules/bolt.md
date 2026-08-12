## 2025-01-20 - [Identity Query Performance]
**Learning:** Removing artificial Task.Delay calls (simulated latency) and converting synchronous LINQ queries on DbContexts/Identity Managers to Entity Framework Core async extensions (ToListAsync) greatly improves throughput and integration test execution speed.
**Action:** Always verify if database or identity queries in controllers or FastEndpoints can be made asynchronous with Microsoft.EntityFrameworkCore and ensure all simulated delays are cleaned up.
