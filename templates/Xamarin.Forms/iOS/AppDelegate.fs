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
        this.LoadApplication(App())
        base.FinishedLaunching(app, options)
