## 2025-05-15 - [API Performance & Read-Only Query Optimization]
**Learning:** Artificial latency (Task.Delay) and synchronous database operations in PublicApi endpoints unnecessarily degrade performance. Furthermore, read-only UI queries benefit from `.AsNoTracking()` to reduce memory overhead and bypass EF's change tracking mechanism.
**Action:** Remove `Task.Delay` from endpoints, replace synchronous `.ToList()` with asynchronous `.ToListAsync(ct)` for Identity Manager queries, and apply `.AsNoTracking()` to read-only specifications used in UI-centric services.
