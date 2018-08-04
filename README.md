## CI / CD

[![Build status](https://ci.appveyor.com/api/projects/status/eed0q7n8ardyq7a9?svg=true)](https://ci.appveyor.com/project/wk-j/agoda-cicd)
[![codecov](https://codecov.io/gh/wk-j/agoda-cicd/branch/master/graph/badge.svg)](https://codecov.io/gh/wk-j/agoda-cicd)
[![sonarcloud](https://sonarcloud.io/api/project_badges/measure?project=agoda-cicd&metric=alert_status)](https://sonarcloud.io/dashboard?id=agoda-cicd)


Tools / Services

- Node 8.0
- yarn 1.7.0 / npm 1.7.0
- .NET Core 2.1
- Git
- xUnit
- https://ci.appveyor.com/
- https://github.com/OpenCover/opencover
- https://codecov.io
- https://sonarcloud.io

Create project

```bash
dotnet new react --output src/ReactApp
```

Run

```bash
ASPNETCORE_ENVIRONMENT=Development
dotnet run src/ReactApp
```

How to set up ano email

- https://github.com/settings/emails
- Keep my email address private

Find global package path

```bash
dotnet nuget locals --list global-packages
```