namespace XFApp.iOS

open UIKit
open Foundation
open Xamarin.Forms.Platform.iOS
open XFApp

[<Register(nameof AppDelegate)>]
type AppDelegate() =
    inherit FormsApplicationDelegate()

    override this.FinishedLaunching(app, options) =        
        Xamarin.Forms.Forms.Init()
        this.LoadApplication(MyApp())
        base.FinishedLaunching(app, options)
