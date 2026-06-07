## 2026-06-07 - Artificial Delays and Synchronous Identity Queries in PublicApi
**Learning:** Found multiple endpoints in PublicApi (CatalogItem, User, Role) using Task.Delay(1000) to simulate latency and synchronous .ToList() on Identity managers. These significantly bloat integration test times (from ~5s to ~16s).
**Action:** Always check PublicApi endpoints for Task.Delay and ensure IQueryable properties from UserManager/RoleManager are awaited with ToListAsync(ct).
