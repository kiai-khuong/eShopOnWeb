## 2025-05-18 - Remove Artificial Delays and Convert Identity Queries to Async in PublicApi

**Learning:** PublicApi user and role listing endpoints contained hardcoded 1-second artificial delays (`Task.Delay(1000)`) and synchronous database queries (`.ToList()`). Removing the delays and switching to EF Core's async `ToListAsync()` extension method eliminates blocking database calls and reduces endpoint response latency by over 1000ms.

**Action:** Always check Identity endpoints for synchronous `.ToList()` calls and artificial delays, replacing them with EF Core async extensions and non-blocking code.
