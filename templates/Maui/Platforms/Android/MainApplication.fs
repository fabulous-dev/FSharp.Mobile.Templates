namespace MauiApp

open Android.App
open Microsoft.Maui

[<Application>]
type MainApplication(handle, ownership) =
    inherit MauiApplication(handle, ownership)

    do MauiApp.Resource.UpdateIdValues()
    
    override _.CreateMauiApp() = MauiProgram.CreateMauiApp()