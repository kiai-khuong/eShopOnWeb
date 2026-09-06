# Bolt Performance Journal

## 2025-05-20 - Identity Endpoints Latency & Async Query Optimization
**Learning:** PublicApi UserList and RoleList endpoints contained artificial 1-second delays (`Task.Delay(1000)`) and blocking synchronous queries (`ToList()`), causing unnecessary request latency and thread pool thread blocking under load.
**Action:** Remove `Task.Delay` and replace `ToList()` with `ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` across Identity management endpoints.
