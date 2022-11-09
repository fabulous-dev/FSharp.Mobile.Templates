namespace App.iOS

open UIKit
open Foundation

[<Register(nameof AppDelegate)>]
type AppDelegate() =
    inherit UIApplicationDelegate()
       
    override val Window = null with get, set

    override this.FinishedLaunching(_, _) =
        this.Window <- new UIWindow(UIScreen.MainScreen.Bounds)

        let vc = new UIViewController()

        let label = new UILabel(this.Window.Frame)
        label.BackgroundColor <-
            if UIDevice.CurrentDevice.CheckSystemVersion(13, 0) then
                UIColor.SystemBackground
            else
                UIColor.White

        label.TextAlignment <- UITextAlignment.Center
        label.Text <- "Hello, .NET 7 and F# 7!"
        vc.View.AddSubview(label)
        
        this.Window.RootViewController <- vc
        this.Window.MakeKeyAndVisible()
        true
       
