# Bolt's Performance Journal

## 2025-02-18 - [Optimizing Identity Queries and Removing Latency Delays]
**Learning:** Removing artificial 1s latency delays in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) and switching Identity queries to async (ToListAsync) dramatically reduces execution time, especially in the test suite where the duration of PublicApiIntegrationTests drops from 17 seconds to ~5 seconds.
**Action:** Always identify artificial delays and convert synchronous queries on Entity Framework DbSets/UserManager/RoleManager to asynchronous methods when running in async contexts to prevent blocking the thread pool and improve response times.
