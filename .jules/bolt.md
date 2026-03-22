## 2025-05-14 - [PublicApi Endpoint Latency and Read-Only Specifications]
**Learning:** Artificial `Task.Delay` calls and synchronous database operations in `PublicApi` endpoints significantly impact integration test duration and overall responsiveness. Additionally, read-only Entity Framework queries benefit from `.AsNoTracking()` to reduce memory tracking overhead.
**Action:** Always check for simulated latency in endpoints and prioritize asynchronous operations (`ToListAsync`) and `AsNoTracking` for read-only specifications to improve performance and scalability.
