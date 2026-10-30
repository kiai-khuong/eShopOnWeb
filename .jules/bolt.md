## 2025-05-18 - Identity Endpoint Async Optimization & Delay Removal
**Learning:** PublicApi endpoints for User and Role management (UserListEndpoint, RoleListEndpoint) contained 1s artificial delays (`Task.Delay`) and performed synchronous database queries (`.ToList()`). Removing these artificial delays and switching to asynchronous EF Core extensions (`ToListAsync()`) eliminates thread pool blocking and significantly reduces endpoint latency.
**Action:** Always check Identity endpoints for synchronous `.ToList()` calls and artificial `Task.Delay` calls when optimizing API responsiveness.
