# Bolt Performance Journal

## 2025-05-18 - Artificial Latency and Synchronous DB Queries in PublicApi Endpoints
**Learning:** Certain API endpoints (e.g., `UserListEndpoint`) contained hardcoded artificial `Task.Delay(1000)` calls and synchronous Entity Framework queries (`.ToList()`) on Identity managers. This introduced unnecessary 1-second latency per request and blocked thread pool threads unnecessarily.
**Action:** Remove `Task.Delay` and convert synchronous Entity Framework queries to async calls (`ToListAsync`) to drastically reduce response times and improve throughput.
