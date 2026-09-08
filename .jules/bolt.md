## 2025-05-18 - Identity Management Endpoints Artificial Latency & Sync Queries

**Learning:** Identity management endpoints (`UserListEndpoint` and `RoleListEndpoint`) contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` EF Core queries on `userManager.Users` and `roleManager.Roles`. Removing the artificial delays and switching to asynchronous `ToListAsync()` eliminates 2000ms of latency and prevents potential thread-pool starvation under load.
**Action:** When working on API endpoints, check for artificial delay calls and synchronous database queries on Identity queries, and replace them with non-blocking `ToListAsync()` calls.
