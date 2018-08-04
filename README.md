## CI / CD

[![Build status](https://ci.appveyor.com/api/projects/status/eed0q7n8ardyq7a9?svg=true)](https://ci.appveyor.com/project/wk-j/agoda-cicd)
[![codecov](https://codecov.io/gh/wk-j/agoda-cicd/branch/master/graph/badge.svg)](https://codecov.io/gh/wk-j/agoda-cicd)
![sonarcloud](https://sonarcloud.io/api/project_badges/measure?project=agoda-cicd&metric=alert_status)


Tools / Services

- Node 8.0
- yarn 1.7.0 / npm 1.7.0
- .NET Core 2.1
- Git
- App veyor
- xUnit
- https://github.com/OpenCover/opencover
- https://codecov.io
- Sonar cloud

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

Sonar cloud

```
dotnet tool install -g dotnet-sonarscanner
dotnet-sonarscanner begin /k:"agoda-cicd" /d:sonar.organization="wk-j-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="940f6517a5a823b166a31a9173557dedbdbc9401"
dotnet build tests/ReactApp.Tests/ReactApp.Tests.csproj
dotnet-sonarscanner end /d:sonar.login="940f6517a5a823b166a31a9173557dedbdbc9401"
```