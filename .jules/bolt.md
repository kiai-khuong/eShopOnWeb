## 2026-06-30 - Removing artificial delays and async Identity queries
**Learning:** Multiple PublicApi endpoints contained artificial 1s delays and synchronous list materialization on Identity managers, which were significant bottlenecks.
**Action:** Always check for 'Task.Delay' and synchronous '.ToList()' in API endpoints during profiling.
