## CI / CD

[![Build status](https://ci.appveyor.com/api/projects/status/eed0q7n8ardyq7a9?svg=true)](https://ci.appveyor.com/project/wk-j/agoda-cicd)

Tools

- Node 8.0
- yarn 1.7.0 / npm 1.7.0
- .NET Core 2.1
- Git
- App veyor
- xUnit
- Sonar cloud
- Code https://codeshare.io/techatagoda20180804

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
- [x] Keep my email address private


Find global tool path

```bash
dotnet nuget locals --list global-packages
```

Coverage

```bash
mono /Users/wk/.nuget/packages/opencover/4.6.519/tools/OpenCover.Console.exe -register:user -oldStyle -target:"dotnet" -targetargs:"test tests/ReactApp.Tests"
```

