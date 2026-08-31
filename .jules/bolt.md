## 2025-05-18 - Identity Query Async Conversion & Delay Elimination

**Learning:** PublicApi identity endpoints (`UserListEndpoint` and `RoleListEndpoint`) had artificial 1-second delays (`Task.Delay(1000)`) and used synchronous LINQ evaluation (`ToList()`) on Entity Framework queries. Eliminating the artificial latency and converting synchronous queries to non-blocking `ToListAsync(ct)` drastically improves endpoint throughput and reduces test execution latency.

**Action:** Whenever optimizing EF Core endpoints, ensure `Microsoft.EntityFrameworkCore` extension methods like `ToListAsync` are used with cancellation tokens and remove artificial delay calls.
