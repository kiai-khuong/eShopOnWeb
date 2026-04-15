
## 2025-05-14 - Artificial Delays in PublicApi Endpoints
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial 1000ms Task.Delay calls. While likely intended to simulate network latency, these significantly increase response times and test suite duration without providing value in a production-like environment.
**Action:** Always check for and remove Task.Delay calls in performance-critical paths unless they serve a specific functional purpose (e.g., debouncing, retry backoff). Replacing synchronous .ToList() with asynchronous .ToListAsync() further improves scalability by freeing up thread pool threads.
