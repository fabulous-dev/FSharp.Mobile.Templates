namespace App.iOS

open UIKit
open Foundation

[<Register(nameof AppDelegate)>]
type AppDelegate() =
    inherit FormsApplicationDelegate()

    override this.FinishedLaunching(_, _) =        
        Xamarin.Forms.Init()
        this.LoadApplication(MyApp(), options)
        base.FinishedLaunching(app, options)
        
       
