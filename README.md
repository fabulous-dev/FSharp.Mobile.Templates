# net6.0-mobile-fsharp

In this repository, you can find all the templates for creating apps on iOS and Android using .NET 6.0 and F# 6.0

### Prerequisites
In order to build and run the Android and iOS projects, you need to install the corresponding workloads
```
dotnet workload install android
dotnet workload install ios
dotnet workload install maccatalyst
dotnet workload install maui
```

For `net6.0-xamarinforms-fsharp`, you'll also need to go into the file `nuget.config` and replace `USERNAME` with your GitHub username and `TOKEN` with your personal access token.
See https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-with-a-personal-access-token

### Available templates
- Blank Android: ✔️
- Blank iOS: ✔️
- Blank Mac Catalyst: ❎ (see [#7](https://github.com/fabulousfx/net6.0-mobile-fsharp/issues/7))
- Xamarin.Forms
  - iOS: ✔️
  - Android: ❎ (see [#5](https://github.com/fabulousfx/net6.0-mobile-fsharp/issues/5))
- Maui: ❎ (see [#8](https://github.com/fabulousfx/net6.0-mobile-fsharp/issues/8))

### Acknowledgements

Thanks @Dolfik1 for the blank Android template.
Thanks @edgarfgp for the blank iOS template.
