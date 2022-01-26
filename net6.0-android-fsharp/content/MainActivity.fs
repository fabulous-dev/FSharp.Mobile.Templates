namespace App.Android

open Android.App
open Android.Content.PM
open Android.Views
open Android.Widget

// type R = App.Android.Resource

[<Activity(Name = "org.fabulous.App.Android.MainActivity", MainLauncher = true)>]
type MainActivity() =
  inherit Activity()
  
  override x.OnCreate(bundle) =
    base.OnCreate(bundle)
    
    let text = new TextView(x)
    text.Text <- "Hello, .NET 6 and F# 6!"
    text.Gravity <- GravityFlags.Center
    text.LayoutParameters <- new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
    
    x.SetContentView(text)