# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.1.1] - 2021-02-21

### Added

- `IGidFactory` and implementation `GidFactory` to create new gid

## [0.1.0] - 2021-02-20

### Added

- CHANGELOG file
- README file describing project
- Azure Pipelines based CI/CD setup
- `IGidParser` and implementation `GidParser` to parse gid
- XML documentation on interfaces
- Test project with unit tests and end-to-end service container registration tests
- Dependency Injection component for service registration in the service container
- `IDependencyInjectionRootComponent` extension `AddGid` to attach component to root component

[unreleased]: https://github.com/SorenA/lightops-gid/compare/0.1.1...develop
[0.1.1]: https://github.com/SorenA/lightops-gid/tree/0.1.1
[0.1.0]: https://github.com/SorenA/lightops-gid/tree/0.1.0
