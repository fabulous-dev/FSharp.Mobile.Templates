namespace XFApp

open Xamarin.Forms

type App() as this =
    inherit Application()

    do this.MainPage <-
        ContentPage(
            Content = Label(
                Text = "Hello from Xamarin.Forms, .NET 6.0 and F# 6.0!",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            )
        )