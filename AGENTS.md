# AGENTS.md

Guidance for coding agents and contributors working in this repository.

## Project Scope
- Solution: `JapaneseCharacters.sln`
- Library: `JapaneseCharacters/`
- Tests: `JapaneseCharacters.Tests/`

## Required Workflow
1. Add or update corresponding unit test case(s) before finalizing code changes.
2. Implement the production code change.
3. Run the relevant test project and confirm tests pass.
4. Update `README.md` when behavior, public API, parameters, or usage expectations changed.

## Testing Expectations
- Place tests in `JapaneseCharacters.Tests/JapaneseCharactersTests.cs` unless a new test file is clearly better.
- Cover both happy path and edge cases for new behavior.
- For conversion overrides, include tests for:
  - Default behavior when custom mappings are empty.
  - Override behavior when valid mappings are provided.
  - Invalid mapping handling.
  - State reset behavior after custom mapping calls.

## Documentation Expectations
- Keep `README.md` aligned with current public methods and parameters.
- When adding options or parameters, document:
  - What they do.
  - Default behavior when omitted or empty.
  - Any important runtime behavior (for example, temporary map override/reset).

## Notes
- Prefer small, focused changes.
- Do not change unrelated files.