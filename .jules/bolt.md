## 2025-05-15 - SDK Mismatch and global.json Management
**Learning:** The environment targets .NET 9.0 but only has SDKs 8.0 and 10.0 installed. Updating `global.json` to 10.0 allows testing with `DOTNET_ROLL_FORWARD=Major`, but this file MUST be reverted before submission as it's considered an unauthorized configuration change.
**Action:** Always revert `global.json` using `git checkout HEAD global.json` before requesting code review or submitting.

## 2025-05-15 - Artificial Delays in PublicApi
**Learning:** Several PublicApi endpoints contain `await Task.Delay(1000, ct);` to simulate latency. Removing these significantly improves response times and reduces test suite duration.
**Action:** Scan for `Task.Delay` in `src/PublicApi` when looking for performance quick wins.
