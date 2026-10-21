## 2025-10-21 - Artificial Delays in PublicApi Endpoints

**Learning:** PublicApi endpoints contain artificial `Task.Delay(1000, ct)` calls that add unnecessary 1-second latency per request without functional benefit.
**Action:** Remove artificial `Task.Delay` calls in endpoint classes to significantly improve API response times and integration test execution speed.
