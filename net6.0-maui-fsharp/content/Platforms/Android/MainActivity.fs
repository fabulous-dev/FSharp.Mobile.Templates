namespace MauiApp

open Android.App
open Android.Content.PM
open Android.OS
open Microsoft.Maui
open Microsoft.Maui.Essentials

[<Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true)>]
type MainActivity() =
    inherit MauiAppCompatActivity()

    override this.OnCreate(savedInstanceState: Bundle) =
        base.OnCreate(savedInstanceState)
        Platform.Init(this, savedInstanceState)

    override this.OnRequestPermissionsResult(requestCode: int, permissions: string[], grantResults: Permission[]) =
        Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults)
        base.OnRequestPermissionsResult(requestCode, permissions, grantResults)