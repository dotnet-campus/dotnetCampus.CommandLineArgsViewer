# 命令行参数查看工具

此工具用来调试命令行参数，可查看经过了不同种类的 Shell 传入此应用的命令行

## 功能

- 查看命令行参数数量，用于调试是否有一个参数被分割为多个或多个参数被合并为一个等
- 调试字符是否被当成分割字符或被转义
- 对比不同种类 Shell 传入到应用程序中参数的不同，如 PowerShell 与 CMD 转义处理的不同
- 对比 Kernel32 方式和 .NET 方式收到的参数的不同

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

例如，在 PowerShell 和 CMD 中输入如下参数，可以得到引号在这两种 Shell 中的不同行为

```
ShowArgs /select,"D:\1,1.txt"
```