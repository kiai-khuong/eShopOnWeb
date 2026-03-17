## 2025-05-15 - [Identify and remove artificial latency and synchronous Identity queries]
**Learning:** Some PublicApi endpoints contain artificial `Task.Delay(1000)` calls to simulate latency. Additionally, use of synchronous `.ToList()` on Identity manager queries can be replaced with `.ToListAsync(ct)` for better performance and scalability.
**Action:** Remove artificial delays and use asynchronous Identity queries in all PublicApi endpoints to ensure optimal performance.
