## 2025-05-18 - Artificial Latency in Public API Endpoints
**Learning:** Public API endpoints in this application may contain artificial `Task.Delay(1000)` calls intended for simulating network latency. Removing these delays yields immediate 1000ms latency improvements per request without breaking downstream functionality.
**Action:** Audit and safely eliminate artificial delay calls in hot path API endpoints while preserving proper async database operations.
