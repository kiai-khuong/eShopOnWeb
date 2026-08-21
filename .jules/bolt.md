## 2025-05-18 - Async Identity Endpoint Queries & Delay Removal
**Learning:** Removing artificial `Task.Delay` delays and replacing synchronous `.ToList()` with asynchronous `ToListAsync()` in EF Core Identity queries on `UserListEndpoint` and `RoleListEndpoint` significantly improves response times and thread pool efficiency in the PublicApi layer.
**Action:** Always prefer asynchronous EF Core query extensions like `ToListAsync()` over synchronous evaluation and ensure artificial delays are eliminated in production endpoints.
