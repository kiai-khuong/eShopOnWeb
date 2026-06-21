## 2026-06-21 - Artificial Delays in PublicApi
**Learning:** Found 1000ms artificial 'Task.Delay' calls in multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) which seem to be used for simulating latency but significantly slow down both the app and the integration test suite.
**Action:** Always check for 'Task.Delay' in PublicApi when optimizing for speed.
