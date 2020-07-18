# 命令行参数查看工具

用来查看经过了 Shell 传入此应用的命令行，此工具用来调试命令行参数

| Build | NuGet |
|--|--|
|![](https://github.com/dotnet-campus/dotnetCampus.CommandLineArgsViewer/workflows/.NET%20Core/badge.svg)|[![](https://img.shields.io/nuget/v/dotnetCampus.CommandLineArgsViewer.svg)](https://www.nuget.org/packages/dotnetCampus.CommandLineArgsViewer)|

## 功能

- 查看命令行参数数量，用于调试是否有一个参数被分割为多个等
- 调试字符是否被当成分割字符或被转义
- 对比 Kernel32 和 .NET 收到的参数的不同

## 安装方法

作为 dotnet 全局工具安装

```
dotnet tool install --global dotnetCampus.CommandLineArgsViewer
```

## Usage

在 `ShowArgs` 命令之后输出需要调试的参数，此时命令行将会输出在应用里面实际收到的参数

```
ShowArgs [args]
```

例如，输入如下参数

```
ShowArgs /select,"D:\1,1.txt"
```