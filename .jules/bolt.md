## 2026-07-14 - Remove artificial delays and optimize Identity queries in PublicApi
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contained artificial 'Task.Delay(1000, ct)' calls and synchronous Identity queries ('.ToList()') that blocked the request thread and artificially inflated response times by 1s per request.
**Action:** Always check for 'Task.Delay' and synchronous materialization of IQueryable (especially on Identity managers) in PublicApi endpoints to improve latency and scalability.
