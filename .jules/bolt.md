## 2025-05-14 - Artificial delays in PublicApi endpoints
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial 1000ms delays (Task.Delay) and synchronous list materialization (.ToList()) on Identity IQueryable properties.
**Action:** When profiling PublicApi, always search for 'Task.Delay' and '.ToList()' on IQueryable to find low-hanging fruit for significant performance gains.
