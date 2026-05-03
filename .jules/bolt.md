## 2026-05-03 - Removing artificial delays in PublicApi
**Learning:** Several PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial 'Task.Delay(1000)' calls, likely for simulating latency. These significantly slow down API responses and integration tests.
**Action:** Always check PublicApi endpoints for 'Task.Delay' and synchronous database calls like '.ToList()' on IQueryable properties.
