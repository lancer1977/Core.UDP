# Core.UDP portfolio roadmap

## Snapshot
- 90-day evidence: 8 commits, 25 files changed
- Last signal: `dc4d008`
- Top modified areas: `docs`, `Tests`, `.pipelines`
- Stack: .NET
- Docs folder: yes
- Roadmap folder: no
- Features docs: yes
- Tests indexed: no

## Implemented now (V1 baseline)
- UDP service and console behavior documented in `sub-module-service.md`, `sub-module-consoleapp1.md`, and `sub-module-models.md`.
- Core capabilities and application logic are tracked in feature docs and solution docs.
- `.pipelines/UDP.yml` and NuGet metadata updates indicate packaging focus.

## Gaps identified
- Tests are present but not currently linked clearly in this scan, so validation coverage is uncertain.
- UDP behavioral paths (timeouts, payload parsing, service lifecycle) need explicit release criteria.
- API changes lack compatibility signaling.

## V1 (stability)
- [ ] Add explicit behavioral tests for UDP message send/receive edge cases and validation.
- [ ] Add startup/shutdown smoke check for console + service integration.
- [ ] Add docs for config and payload schemas with examples.
- [ ] Add release gate tying feature docs to package metadata updates.

## V2 (confidence)
- [ ] Add observability and health guidance for runtime UDP behavior.
- [ ] Expand CI coverage and runbook for payload compatibility.
- [ ] Standardize changelog policy for breaking transport behavior.
- [ ] Add compatibility matrix for target frameworks and runtime environments.

## V10 (scale)
- [ ] Formalize transport contract evolution and deprecation process.
- [ ] Add governance for benchmarked performance and reliability expectations.
- [ ] Build reusable release checklist for transport-focused core packages.
- [ ] Expand contributor ownership and review standards by feature module.

## Release checklist
- [ ] UDP service change includes validation command and docs update.
- [ ] Pipeline and package metadata changes are review-gated.
- [ ] Public behavior change includes rollback guidance.
