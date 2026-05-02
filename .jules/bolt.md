## 2026-05-02 - [Artificial Latency in PublicApi]
**Learning:** Found several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) with hardcoded 'Task.Delay(1000)' calls, likely for simulating latency during development.
**Action:** Always scan for 'Task.Delay' when profiling this codebase for low-hanging performance wins.
