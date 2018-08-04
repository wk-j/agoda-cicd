## CI / CD

[![Build status](https://ci.appveyor.com/api/projects/status/eed0q7n8ardyq7a9?svg=true)](https://ci.appveyor.com/project/wk-j/agoda-cicd)

Tools / Services

- Node 8.0
- yarn 1.7.0 / npm 1.7.0
- .NET Core 2.1
- Git
- App veyor
- xUnit
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