# Core.UDP Roadmap (v1)

This local planning file has been migrated. GitHub Issues are the canonical tracker.

Canonical GitHub issue: https://github.com/lancer1977/Core.UDP/issues/5
Original source kind: roadmap

## Vision

Keep Core.UDP as a small, testable .NET UDP transport library with clear
listener, transmitter, serialization, and package-validation boundaries.

## Current Status

- [x] In progress
- [ ] Stable
- [ ] Stubbed

## Goals

- Keep the native validation command documented and runnable from a fresh
  checkout.
- Keep the listener and transmitter behavior covered by deterministic tests.
- Run CI on every main-branch and pull-request change.
- Treat package metadata, dependency drift, and transport behavior changes as
  release-gated work.

## Known Gaps

- `PolyhydraSoftware.Core.UDP.sln` is a legacy solution file with no restoreable
  projects; use `Core.UDP.sln` for validation.
- Dependency updates are intentionally tracked separately from the validation
  repair.
- Runtime UDP behavior beyond loopback still needs environment-specific smoke
  proof before release claims.

## Validation

Run the native validation path from the repo root:

```bash
dotnet test Core.UDP.sln --configuration Release
```

The 2026-06-29 validation baseline is recorded in
[`docs/validation.md`](../../validation.md).
