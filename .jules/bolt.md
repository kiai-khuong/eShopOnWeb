## 2025-05-22 - Artificial Task.Delay in PublicApi Endpoints
**Learning:** The PublicApi endpoints in eShopOnWeb contain intentional 1000ms artificial delays to simulate network latency in demo scenarios. These delays significantly slow down the application and integration tests.
**Action:** Remove `Task.Delay(1000, ct)` calls in PublicApi endpoints to improve performance and test execution speed.
