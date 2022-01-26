namespace MauiApp

open Microsoft.Maui.Controls

type App() as this =
    inherit Application()

    do this.MainPage <- MainPage()