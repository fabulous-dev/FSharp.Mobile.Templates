# FSharp.Mobile.Templates

In this repository, you can find all the templates for creating apps on iOS and Android using .NET 6.0 and F# 6.0

### Prerequisites
In order to build and run the Android and iOS projects, you need to install the corresponding workloads
```
dotnet workload install android
dotnet workload install ios
dotnet workload install maccatalyst
dotnet workload install maui
```

For the Xamarin.Forms template, you'll also need to go into the file `nuget.config` and replace `USERNAME` with your GitHub username and `TOKEN` with your personal access token.
See https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-with-a-personal-access-token

### Available templates
- Android
- iOS
- Mac Catalyst
- Xamarin.Forms (Android, iOS)
- Maui (Android, iOS, Mac Catalyst, Windows, Tizen)

### Known issues

- First build fails on Android (native, XF and MAUI)
  - You need to compile 2 times to get it working. It's a current limitation of FSharp.Android.Resource used to expose the resources.
  - You might also need to unload/reopen either the Android project or the solution for Intellisense to find the resources

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
F# Xamarin.Forms Application  xf-fsharp           F#        FSharp.Mobile
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
$ dotnet new -i .\bin\Release\FSharp.Mobile.Templates.0.0.4.nupkg
```

### Acknowledgements

Thanks [@Dolfik1](https://github.com/Dolfik1) for the blank Android template.  
Thanks [@edgarfgp](https://github.com/edgarfgp) for the blank iOS template.
