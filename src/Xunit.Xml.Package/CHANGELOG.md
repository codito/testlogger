# Changelog

## Unreleased (v4.0.x)

## v3.1.20 - 2024/02/10

- Update core testlogger to 3.1.140.
- Fix: exclude code coverage instrumentation for test loggers. See
  https://github.com/spekt/junit.testlogger/issues/64 and
  https://github.com/spekt/junit.testlogger/issues/72.

## v3.1.17 - 2023/09/17

- Fix for reporting nested test classes. See #48 and
  https://github.com/spekt/testlogger/pull/41/. Thanks @pageyboy.
- Update core testlogger to 3.1.138.
- Infra: fix build when repo is cloned in path with whitespace.

## v3.1.11 - 2023/07/06

- Update core testlogger to 3.1.130.
- Fix for illegal xml characters in various names. See https://github.com/spekt/testlogger/pull/37
- Use DisplayName for method names. See https://github.com/spekt/xunit.testlogger/pull/46
- Various infra fixes: move to net7.0, add github CI and remove appveyor.

## v3.0.78 - 2023/01/30

- Update core testlogger to 3.0.86 for xunit test adapter
- Fix: Explicit tests should be marked as Skipped. See
  https://github.com/spekt/nunit.testlogger/issues/86
- Replace Test Case name parser **Possible Breaking Change**
  - For most or maybe all users the new parser should fix the issues shown below, without introducing new issues. In case you do encounter any new parsing failures a feature flag `Parser=Legacy` has been added to use the prior parser. See [logger config wiki](https://github.com/spekt/testlogger/wiki/Logger-Configuration) for details.
  - Fix: Test case parse error if name contains special characters. See
    https://github.com/spekt/nunit.testlogger/issues/90
  - Fix: Covers several parsing issues. Thanks @becha2 for all the detailed examples.
    https://github.com/spekt/testlogger/issues/28
  - Fix: Log member data. Thanks @BottlecapDave for the issue report and @hach-que for the draft fix.
    https://github.com/spekt/junit.testlogger/issues/50
  - Fix: Issue parsing chars. Thanks @binarycow for the issue report.
    https://github.com/spekt/nunit.testlogger/issues/90
  - Reduce log verbosity: The parser, if it encounters problems, will only output one warning per run to the console instead of one per problem
  - Fix: Issue parsing numbers. See https://github.com/spekt/testlogger/issues/35

## v3.0.70 - 2021/11/01

- Upgrade testlogger to 3.0.47
- Fix: generate test results when used along with JUnit.TestLogger. See
  https://github.com/spekt/xunit.testlogger/issues/36 and
  https://github.com/spekt/xunit.testlogger/issues/37

## v3.0.66 - 2021/03/10

- Upgrade testlogger to 3.0.31
- Fix: overwrite test result file if it already exists. See
  https://github.com/spekt/nunit.testlogger/issues/76

## v3.0.62 - 2021/02/03

- Remove unused code from refactoring. See #31
- Ensure Traits for Tests are available in the report. Use `TestResultInfo.TestCase.Traits`
  instead of `TestResultInfo.Traits`. See #32

## v3.0.56 - 2021/01/31

- Refactor to support [core testlogger][]
- Compatibility: minimum framework is netstandard1.5 and TestPlatform 15.5.0
- Use test run start and end times for run duration reporting for assembly. See #26
- Escape control characters from the generated xml. See #25
- Token expansion for `{assembly}` and `{framework}` in results file. See
  https://github.com/spekt/testlogger/wiki/Logger-Configuration

[core testlogger]: https://github.com/spekt/testlogger
