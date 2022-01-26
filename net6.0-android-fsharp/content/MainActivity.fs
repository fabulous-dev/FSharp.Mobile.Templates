namespace App.Android

open Android.App
open Android.Content.PM
open Android.Widget

// type R = App.Android.Resource

[<Activity(
  Name = "org.fabulous.App.Android.MainActivity",
  Label = "F# Android app on .NET 6.0",
  MainLauncher = true,
  LaunchMode = LaunchMode.SingleTask)>]
type MainActivity() =
  inherit Activity()
  
  override x.OnCreate(bundle) =
    base.OnCreate(bundle)
    
    let text = new TextView(x)
    text.Text <- "Hello, F#!"
    x.SetContentView(text)