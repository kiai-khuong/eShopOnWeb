## 2025-05-18 - Removing Artificial Latency in Public API Endpoints
**Learning:** Endpoints in the PublicApi project contained artificial `Task.Delay(1000)` calls simulating network/processing latency. Removing these delays yields immediate 1000ms response time improvements per request and speeds up integration tests significantly.
**Action:** Always scan for artificial delays (`Task.Delay`) in API endpoints when auditing for quick performance wins.
