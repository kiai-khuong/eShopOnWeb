## 2026-05-31 - Artificial delays and synchronous materialization in PublicApi
**Learning:** Found artificial 1000ms Task.Delay calls and synchronous .ToList() calls in multiple PublicApi endpoints (CatalogItemListPaged, UserList, RoleList). These significantly inflate response times and block threads.
**Action:** Always scan for Task.Delay and .ToList() when profiling PublicApi endpoints in this codebase to identify quick performance wins.
