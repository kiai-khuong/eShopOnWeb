## 2025-05-18 - Identity Endpoints Artificial Delay & Blocking Calls
**Learning:** `UserListEndpoint` and `RoleListEndpoint` contained artificial 1-second delays (`Task.Delay(1000)`) and synchronous database execution (`.ToList()`) on Identity managers.
**Action:** Remove `Task.Delay` and convert `.ToList()` to EF Core's asynchronous `ToListAsync()` to eliminate unnecessary latency and avoid thread pool starvation under high concurrent load.
