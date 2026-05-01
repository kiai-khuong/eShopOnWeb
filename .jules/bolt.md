## 2026-05-01 - [Artificial Latency in PublicApi]
**Learning:** Found several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) with hardcoded 'Task.Delay(1000)' calls, likely intended to simulate network latency but significantly impacting response times and test durations.
**Action:** Always check for 'Task.Delay' when profiling PublicApi endpoints in this codebase. Removing them yields an immediate 1s improvement per call.

## 2026-05-01 - [Identity Queries are Synchronous]
**Learning:** Identity manager properties (UserManager.Users, RoleManager.Roles) were being queried using synchronous '.ToList()', which blocks threads.
**Action:** Use '.ToListAsync(ct)' from 'Microsoft.EntityFrameworkCore' to ensure non-blocking database I/O for Identity operations.
