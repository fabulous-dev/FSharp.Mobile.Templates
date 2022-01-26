namespace App

open Xamarin.Forms

type MyApp() as this =
    inherit Application()

    do this.MainPage <- ContentPage(Content = Label(Text = "Hello from XF on .NET 6.0/F# 6.0"))