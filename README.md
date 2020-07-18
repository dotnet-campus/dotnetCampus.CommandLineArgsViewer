# dotnetCampus.CommandLineArgsViewer

You can view all the arguments passed from shells to this tool which helps you to debug command-lines.

| Build | NuGet |
|--|--|
|![](https://github.com/dotnet-campus/dotnetCampus.CommandLineArgsViewer/workflows/.NET%20Core/badge.svg)|[![](https://img.shields.io/nuget/v/dotnetCampus.CommandLineArgsViewer.svg)](https://www.nuget.org/packages/dotnetCampus.CommandLineArgsViewer)|

## Feature

- View the count of the arguments.
- The characters which are escaped.
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