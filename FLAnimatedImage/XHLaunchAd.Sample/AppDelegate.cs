﻿using Foundation;
using UIKit;
using XHLaunchAd;

namespace XHLaunchAd.Sample
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            InitLoadVideoAd();

            return true;
        }

        private void InitLoadImageAd()
        {
            XHLaunchAd.SetLaunchSourceType(SourceType.Image);
            XHLaunchImageAdConfiguration imageAdConfiguration = XHLaunchImageAdConfiguration.DefaultConfiguration;
            imageAdConfiguration.Duration = 5;
            imageAdConfiguration.Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Size.Width, UIScreen.MainScreen.Bounds.Height);
            imageAdConfiguration.ImageNameOrURLString = "image12.gif";
            imageAdConfiguration.ContentMode = UIViewContentMode.ScaleAspectFill;
            imageAdConfiguration.GIFImageCycleOnce = true;
            imageAdConfiguration.ShowFinishAnimate = ShowFinishAnimate.FlipFromLeft;
            imageAdConfiguration.ShowFinishAnimateTime = 0.8f;
            imageAdConfiguration.SkipButtonType = SkipType.TimeText;
            imageAdConfiguration.ShowEnterForeground = true;
            imageAdConfiguration.OpenModel = new NSString("https://www.baidu.com");
            XHLaunchAd.ImageAdWithImageAdConfiguration(imageAdConfiguration, this);
        }

        private void InitLoadVideoAd()
        {
            XHLaunchAd.SetLaunchSourceType(SourceType.Image);
            XHLaunchVideoAdConfiguration videoAdConfiguration = XHLaunchVideoAdConfiguration.DefaultConfiguration;
            videoAdConfiguration.VideoNameOrURLString = "video0.mp4";
            videoAdConfiguration.OpenModel = new NSString("https://www.baidu.com");
            XHLaunchAd.VideoAdWithVideoAdConfiguration(videoAdConfiguration, this);
        }

        private void InitNetworkImageAd()
        {
            XHLaunchAd.SetLaunchSourceType(SourceType.Image);
            XHLaunchAd.SetWaitDataDuration(5);

            XHLaunchImageAdConfiguration imageAdConfiguration = XHLaunchImageAdConfiguration.DefaultConfiguration;
            imageAdConfiguration.Duration = 5;
            imageAdConfiguration.Frame = new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Size.Width, UIScreen.MainScreen.Bounds.Height);
            imageAdConfiguration.ImageNameOrURLString = "https://upload-images.jianshu.io/upload_images/4421101-1301dea142ae4bd2.png";
            imageAdConfiguration.ContentMode = UIViewContentMode.ScaleAspectFill;
            imageAdConfiguration.GIFImageCycleOnce = true;
            imageAdConfiguration.ImageOption = XHLaunchAdImageOptions.Default;
            imageAdConfiguration.ShowFinishAnimate = ShowFinishAnimate.FlipFromLeft;
            imageAdConfiguration.ShowFinishAnimateTime = 0.8f;
            imageAdConfiguration.SkipButtonType = SkipType.TimeText;
            imageAdConfiguration.ShowEnterForeground = true;
            imageAdConfiguration.OpenModel = new NSString("https://www.baidu.com");
            XHLaunchAd.ImageAdWithImageAdConfiguration(imageAdConfiguration, this);
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}

