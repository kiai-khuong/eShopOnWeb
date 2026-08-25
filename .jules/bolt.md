## 2025-05-15 - Artificial Latency Delays in API Endpoints
**Learning:** PublicApi endpoints contain hardcoded artificial `Task.Delay(1000, ct)` calls that significantly degrade API response times and slow down integration test suites.
**Action:** Remove unnecessary `Task.Delay` calls in API endpoints to instantly improve throughput and response times.
