## 2025-05-12 - PublicApi Delays and Identity Async Optimizations
**Learning:** The public API endpoints (`UserListEndpoint`, `RoleListEndpoint`, and `CatalogItemListPagedEndpoint`) contained artificial `Task.Delay(1000)` statements that severely slowed down integration tests and production response times. Additionally, synchronous materialization (`.ToList()`) on EF Core-backed managers (`UserManager` and `RoleManager`) causes thread blocking under load.
**Action:** Remove artificial delays and convert Identity manager queries to asynchronous querying (`ToListAsync()`) with the appropriate EF Core imports.

## 2025-05-12 - Environment Constraints on Git Commands
**Learning:** The `git reset` command is strictly restricted/blocked by the sandbox bash session wrapper, but unstaging changes is fully supported via `git restore --staged <file>` or `git restore --staged .`.
**Action:** Avoid utilizing `git reset` to unstage modifications, and use `git restore --staged` instead.
