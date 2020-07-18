# dotnetCampus.CommandLineArgsViewer

This tool is used to observe that the parameters of the incoming command line are as expected.

| Build | NuGet |
|--|--|
|![](https://github.com/dotnet-campus/dotnetCampus.CommandLineArgsViewer/workflows/.NET%20Core/badge.svg)|[![](https://img.shields.io/nuget/v/dotnetCampus.CommandLineArgsViewer.svg)](https://www.nuget.org/packages/dotnetCampus.CommandLineArgsViewer)|

## Feature

- Observe the count of the arguaments.
- The character that is escaped.
- The difference between Kernal32 and .NET

## Install

```
dotnet tool install --global dotnetCampus.CommandLineArgsViewer
```

## Usage

Input the arguments after ShowArgs, and you will find what is the application actually received arguments.

```
ShowArgs [args]
```

