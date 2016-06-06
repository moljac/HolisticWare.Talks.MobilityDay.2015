using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest.HAK
{
    public class AppInitializer
    {
        private static string app_file_android_apk =
            //"/Users/moljac/Projects/Samples/Samples.Xamarin.UITest/samples/Native-Full-Hybrid/app-files-native/Android/com.infinum.hak-1/base.apk"
            //"../../app-files-native/Android/com.infinum.hak-1/base.apk"
            @"D:\lara\HolisticWare.Talks.MobilityDay.2015\samples\02-Xamarin.UITest\029-Xamarin.UITest-Native-Full-Hybrid\app-files-native\Android\vecernjilistlite.institut.hr-1\\base.apk"
            //"D:\\lara\\HolisticWare.Talks.MobilityDay.2015\\samples\\02-Xamarin.UITest\\029-Xamarin.UITest-Native-Full-Hybrid\\app-files-native\\Android\\com.infinum.hak-1\\base.apk"
            ;
        private static string app_file_ios_ipa =
            //"/Users/moljac/Projects/Samples/Samples.Xamarin.UITest/samples/Native-Full-Hybrid/app-files-native/iOS/HAK/HAK 2.6.6.ipa"
            "D:\\lara\\HolisticWare.Talks.MobilityDay.2015\\samples\\02-Xamarin.UITest\\029-Xamarin.UITest-Native-Full-Hybrid\\app-files-native\\iOS\\HAK\\HAK 2.6.6.ipa"
            ;

        public static IApp StartApp(Platform platform)
        {
            IApp app = null;

            // TODO: If the iOS or Android app being tested is included in the solution 
            // then open the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            if (platform == Platform.Android)
            {
                app =
                    ConfigureApp
                        .Android
                        .Debug()
                        // TODO: Update this path to point to your Android app and uncomment the
                        // code if the app is not included in the solution.
                        .ApkFile(app_file_android_apk)
                        .StartApp()
                        ;
            }
            else if (platform == Platform.iOS)
            {
                app =
                    ConfigureApp
                        .iOS
                        .Debug()
                        // TODO: Update this path to point to your iOS app and uncomment the
                        // code if the app is not included in the solution.
                        .AppBundle(app_file_ios_ipa)
                        .StartApp()
                        ;
            }

            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("mainnews_box_category_first_text")); ;
            app.Tap(c => c.Marked("txt_news_title")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Tap(c => c.Marked("showcase_button")); ;
            app.Flash(c => c.Marked("action_bar_title")); ;
            app.Flash(c => c.Marked("action_bar_title")); ;
            app.Tap(c => c.Marked("action_bar_title")); ;

            app.Repl();

            return app;
        }
    }
}

