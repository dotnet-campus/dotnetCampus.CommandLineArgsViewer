# dotnetCampus.CommandLineArgsViewer

This is a tool to debug command-lines that you can view all the arguments passed from shells.

[中文](docs/zh-cn/README.md)

| Build | NuGet |
|--|--|
|![](https://github.com/dotnet-campus/dotnetCampus.CommandLineArgsViewer/workflows/.NET%20Core/badge.svg)|[![](https://img.shields.io/nuget/v/dotnetCampus.CommandLineArgsViewer.svg)](https://www.nuget.org/packages/dotnetCampus.CommandLineArgsViewer)|

## Feature

- View the count of the arguments.
- View the shell escaping behavior of any characters (quote etc.)
- View the command line loss from the shells (e.g. PowerShell lost quotes comparing to CMD).
- View the command line loss of the .NET version comparing with the Kernel32 version.

## Install

```
dotnet tool install --global dotnetCampus.CommandLineArgsViewer
```

## Usage

Type any arguments after the command `ShowArgs`, and you'll view the command-line and args that an app (or a .NET app) will actually receive.

```
ShowArgs [args]
```

For example, you can type the command line below:

```
ShowArgs /select,"D:\1,1.txt"
```