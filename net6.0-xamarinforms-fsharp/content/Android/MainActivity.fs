namespace App.Android

open Android.App
open Android.Content.PM
open Android.Widget
open Xamarin.Forms.Platform.Android

open App

// type R = App.Android.Resource

[<Activity(
  Name = "org.fabulous.App.Android.MainActivity",
  Label = "F# XF .NET 6.0",
  MainLauncher = true,
  LaunchMode = LaunchMode.SingleTask)>]
type MainActivity() =
  inherit FormsAppCompatActivity()
  
  override this.OnCreate(bundle) =
    base.OnCreate(bundle)
    
    Xamarin.Forms.Forms.Init(this, bundle)
    this.LoadApplication(MyApp())