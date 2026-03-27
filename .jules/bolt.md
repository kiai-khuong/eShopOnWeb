## 2025-05-15 - [Use AsNoTracking for catalog filters]
**Learning:** In Entity Framework Core, using `.AsNoTracking()` for read-only queries (like catalog filters and paginated lists) significantly reduces memory overhead and improves performance by skipping the Change Tracker.
**Action:** Always apply `.AsNoTracking()` to specifications used exclusively for read-only UI components.
