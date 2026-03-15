## 2025-05-15 - [Artificial Latency and Async Throughput in PublicApi]
**Learning:** The `PublicApi` project contained several endpoints with artificial `Task.Delay(1000)` calls, likely for UI demonstration purposes. Additionally, some Identity-related queries were using synchronous `.ToList()`, which blocks thread pool threads.
**Action:** Always scan for `Task.Delay` in new codebases to ensure no demo latency remains. Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` for all asynchronous database operations in the `PublicApi` to maximize throughput.
