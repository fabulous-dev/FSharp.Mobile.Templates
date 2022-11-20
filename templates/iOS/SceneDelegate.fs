namespace App.iOS

open System.Runtime.InteropServices
open UIKit
open Foundation

[<Register(nameof SceneDelegate)>]
type SceneDelegate() =
    inherit UIWindowSceneDelegate()

    override val Window = null with get, set

    override this.WillConnect(scene: UIScene, _: UISceneSession, _: UISceneConnectionOptions) =
        let scene = scene :?> UIWindowScene

        let win =
            new UIWindow(scene.CoordinateSpace.Bounds)

        let label = new UILabel()

        label.BackgroundColor <-
            if UIDevice.CurrentDevice.CheckSystemVersion(13, 0) then
                UIColor.SystemBackground
            else
                UIColor.White

        let vc = new UIViewController()
        label.TextAlignment <- UITextAlignment.Center
        label.TranslatesAutoresizingMaskIntoConstraints <- false
        label.Text <- "Hello, .NET 7 and F# 7!"
        vc.View.AddSubview(label)

        NSLayoutConstraint.ActivateConstraints(
            [| label.TopAnchor.ConstraintEqualTo(vc.View.TopAnchor, NFloat 0.)
               label.LeadingAnchor.ConstraintEqualTo(vc.View.LeadingAnchor, NFloat 0.)
               label.TrailingAnchor.ConstraintEqualTo(vc.View.TrailingAnchor, NFloat 0.)
               label.BottomAnchor.ConstraintEqualTo(vc.View.BottomAnchor, NFloat 0.) |]
        )

        win.RootViewController <- vc
        this.Window <- win
        win.WindowScene <- scene
        win.MakeKeyAndVisible()

    override _.DidDisconnect(_: UIScene) = ()
    // Called as the scene is being released by the system.
    // This occurs shortly after the scene enters the background, or when its session is discarded.
    // Release any resources associated with this scene that can be re-created the next time the scene connects.
    // The scene may re-connect later, as its session was not necessarily discarded (see UIApplicationDelegate `DidDiscardSceneSessions` instead).
    override _.DidBecomeActive(_: UIScene) = ()
    // Called when the scene has moved from an inactive state to an active state.
    // Use this method to restart any tasks that were paused (or not yet started) when the scene was inactive.

    override _.WillResignActive(_: UIScene) = ()
    // Called when the scene will move from an active state to an inactive state.
    // This may occur due to temporary interruptions (ex. an incoming phone call).

    override _.WillEnterForeground(_: UIScene) = ()
    // Called as the scene transitions from the background to the foreground.
    // Use this method to undo the changes made on entering the background.

    override _.DidEnterBackground(_: UIScene) = ()
    // Called as the scene transitions from the foreground to the background.
    // Use this method to save data, release shared resources, and store enough scene-specific state information
    // to restore the scene back to its current state.
