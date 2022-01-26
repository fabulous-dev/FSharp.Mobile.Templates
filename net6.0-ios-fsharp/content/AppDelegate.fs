namespace App.iOS

open UIKit
open Foundation

[<Register(nameof AppDelegate)>]
type AppDelegate() =
    inherit UIApplicationDelegate()
       
    override val Window = null with get, set

    override this.FinishedLaunching(_, _) =
        let vc = new UIViewController()
        let label = new UILabel(Text = "Hello iOS with F# .NET 6.0!")
        vc.Add(label)
        
        this.Window <- new UIWindow(UIScreen.MainScreen.Bounds)
        this.Window.RootViewController <- vc
        this.Window.MakeKeyAndVisible()
        true
        
       
