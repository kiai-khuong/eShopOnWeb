## 2025-05-14 - Artificial Delays and Sync Queries in PublicApi
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) had 'await Task.Delay(1000)' calls, likely to simulate latency. Additionally, Identity queries were using synchronous '.ToList()' on 'IQueryable', which blocks threads.
**Action:** Always check for 'Task.Delay' and synchronous materialization of 'IQueryable' in PublicApi endpoints to find easy performance wins.
