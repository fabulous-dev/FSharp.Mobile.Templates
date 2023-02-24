# FSharp.Mobile.Templates

In this repository, you can find all the templates for creating mobile and desktop apps using .NET 8.0 and F# 7.0.

Please note that those templates are "plain" F# templates, no additional dependencies. If you are interested in the Fabulous templates you can use:

- [Fabulous.XamarinForms templates](https://github.com/fabulous-dev/Fabulous.XamarinForms)
- [Fabulous.MauiControls templates](https://github.com/fabulous-dev/Fabulous.MauiControls)
- [Fabulous.Avalonia templates](https://github.com/fabulous-dev/Fabulous.Avalonia)

### Prerequisites
In order to build and run the Android and iOS projects, you need to install the corresponding workloads
```
dotnet workload install android
dotnet workload install ios
dotnet workload install maccatalyst
dotnet workload install maui
```

### Available templates
- Android
- iOS
- Mac Catalyst
- Maui (Android, iOS, Mac Catalyst, Windows, Tizen)

### Install

```
$ dotnet new -i FSharp.Mobile.Templates
```

### How to use

After installation, several templates will be added:

```
$ dotnet new


Template Name                 Short Name          Language  Tags         
----------------------------  ------------------- --------  -------------
F# Android Application        android-fsharp      F#        FSharp.Mobile
F# iOS Application            ios-fsharp          F#        FSharp.Mobile
F# Maui Application           maui-fsharp         F#        FSharp.Mobile
F# Mac Catalyst Application   maccatalyst-fsharp  F#        FSharp.Mobile
```

To create a project, use `dotnet new`:

```
$ mkdir TestApp
$ cd TestApp
$ dotnet new android-fsharp
```

After creating the application, you can build it with `dotnet build`:

```
$ dotnet build -c Release
```

### Build

To build and test the templates locally:

```
$ dotnet pack -c Release
$ dotnet new -i .\bin\Release\FSharp.Mobile.Templates.8.0.0.nupkg
```

### Acknowledgements

Thanks [@Dolfik1](https://github.com/Dolfik1) for the blank Android template.  
Thanks [@edgarfgp](https://github.com/edgarfgp) for the blank iOS template.
