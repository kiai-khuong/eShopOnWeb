## 2025-05-18 - Remove Artificial Latency Delays in Public API Endpoints
**Learning:** Public API endpoints may contain artificial `Task.Delay` calls simulating slow downstream network/services. Removing these delays eliminates 1000ms of latency per request without changing API response structures.
**Action:** Inspect PublicApi endpoints for simulated delay calls when looking for quick latency improvements.
