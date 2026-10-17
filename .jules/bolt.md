## 2025-05-18 - Eliminating Artificial Latency & Converting Synchronous Identity Queries in Endpoints

**Learning:** PublicApi management endpoints contained artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` EF Core queries on `UserManager`/`RoleManager`. Removing these delays and leveraging `ToListAsync()` improves response latency from ~1000ms+ down to single-digit milliseconds while freeing up thread pool threads under load.

**Action:** Always check `PublicApi` endpoints for artificial delays or synchronous database calls, and replace `.ToList()` with EF Core's `ToListAsync()` using `Microsoft.EntityFrameworkCore`.
