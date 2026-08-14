# Bolt's Performance Journal

## 2025-05-18 - Identity Queries & Artificial Delay Removal
**Learning:** `UserListEndpoint` contained an artificial 1-second delay `Task.Delay(1000)` and used synchronous `.ToList()` query execution on `UserManager.Users`. Removing the delay and using EF Core's `ToListAsync()` eliminates artificial latency and prevents thread pool starvation.
**Action:** Always inspect endpoints for artificial delays and synchronous I/O, replacing them with asynchronous EF Core extensions (`ToListAsync`).
