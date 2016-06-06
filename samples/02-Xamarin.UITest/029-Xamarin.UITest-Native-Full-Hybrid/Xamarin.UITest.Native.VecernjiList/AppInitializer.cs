using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.UITest.Native.VecernjiList
{
	public class AppInitializer
	{
		private static string  app_file_android_apk = 
			//"/Users/moljac/Projects/Samples/Samples.Xamarin.UITest/samples/Native-Full-Hybrid/app-files-native/Android/vecernjilistlite.institut.hr-1/base.apk"
			@"D:\lara\HolisticWare.Talks.MobilityDay.2015\samples\02-Xamarin.UITest\029-Xamarin.UITest-Native-Full-Hybrid\app-files-native\Android\vecernjilistlite.institut.hr-1\base.apk"
			;
		private static string  app_file_ios_ipa = 
			//"/Users/moljac/Projects/HolisticWare/Talks/HolisticWare.Talks.MobilityDay.2015/samples/02-Xamarin.UITest/029-Xamarin.UITest-Native-Full-Hybrid/app-files-native/iOS/VL/Večernji list 2.24.ipa"
			// "/Users/moljac/Projects/Samples/Samples.Xamarin.UITest/samples/Native-Full-Hybrid/app-files-native/iOS/VL/Večernji list 2.24.ipa"
			@"D:\lara\HolisticWare.Talks.MobilityDay.2015\samples\02-Xamarin.UITest\029-Xamarin.UITest-Native-Full-Hybrid\app-files-native\iOS\VL\\Večernji list 2.24.ipa"
			;

		static IApp app = null;

		public static IApp StartApp (Platform platform)
		{

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
						.ApkFile (app_file_android_apk)
						.StartApp ()
						;

				//app.Repl ();
				DoSomeTest();
			}
			else if (platform == Platform.iOS)
			{
				app = 
					ConfigureApp
						.iOS
						.Debug()
						// TODO: Update this path to point to your iOS app and uncomment the
						// code if the app is not included in the solution.
						.AppBundle (app_file_ios_ipa)
						.StartApp ()
						;

				app.Repl ();
			}

			return app;
		}


		public static void DoSomeTest ()
		{
			app.Tap(c => c.Marked("OK")); ;
			app.Tap(c => c.Marked("OK")); ;
			app.Tap(c => c.Marked("OK")); ;
			app.Tap(c => c.Marked("OK")); ;
			app.Tap(c => c.Marked("OK")); ;

			app.Tap(c => c.Marked("Povratak")); ;
			app.Tap(c => c.Marked("Sport")); ;
			app.Tap(c => c.Marked("Strani nogomet")); ;
			app.Tap(c => c.Marked("prije 7 dana")); ;
			app.Tap(c => c.Marked("Povratak")); ;
			app.Tap(c => c.Marked("Navigate home")); ;
			app.Tap(c => c.Marked("Vijesti")); ;

			return;
		}
	}
}

