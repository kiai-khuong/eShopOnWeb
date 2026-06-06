## 2025-05-14 - Artificial delays and sync queries in PublicApi
**Learning:** The PublicApi project contained multiple endpoints with 1s artificial delays (`Task.Delay(1000)`) and synchronous database materialization (`ToList()`) on Identity Manager properties. These are significant bottlenecks for response times and scalability.
**Action:** Always check `src/PublicApi` for `Task.Delay` and synchronous `ToList()` calls on `IQueryable` properties. Use `ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to resolve the latter.
