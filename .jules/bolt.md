# Bolt's Journal - eShopOnWeb Performance Optimization

## 2025-05-10 - [Simulated Latency and Synchronous DB Querying in Identity Endpoints]
**Learning:** Multiple PublicApi endpoints (UserList, RoleList) contained artificial 1000ms Task.Delay calls and blocked threads using synchronous .ToList() queries against Identity Managers (UserManager/RoleManager) instead of asynchronous querying (ToListAsync). Removing these latency simulators and switching to Entity Framework Core's asynchronous extensions (by importing Microsoft.EntityFrameworkCore) dramatically improves response times and throughput under load.
**Action:** Always scan for simulated latency (Task.Delay) in public-facing API endpoints, and convert synchronous repository/Identity queries to non-blocking async calls using EF Core extensions like ToListAsync().
