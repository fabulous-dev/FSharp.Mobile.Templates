namespace MauiApp

open Microsoft.Maui.Hosting
open Microsoft.Maui.Controls.Hosting

type MauiProgram =
    static member CreateMauiApp() : MauiApp =
        MauiApp
            .CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fun fonts ->
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular") |> ignore
            )
            .Build()