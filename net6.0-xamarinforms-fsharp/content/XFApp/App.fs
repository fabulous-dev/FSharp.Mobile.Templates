namespace XFApp

open Xamarin.Forms

type MyApp() as this =
    inherit Application()

    do this.MainPage <-
        ContentPage(
            Content = Label(
                Text = "Hello from Xamarin.Forms, .NET 6 and F# 6!"
            )
        )