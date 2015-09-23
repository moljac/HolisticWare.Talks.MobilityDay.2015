using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace UITest.XamarinAndroid
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile ("../../../Tasky.Droid/bin/Release/com.xamarin.samples.taskydroid.apk")
				.StartApp ();


			app.Screenshot("uslika.png");

			//app.Repl();

			return;
		}

		[Test]
		public void AppLaunches ()
		{
			app.Screenshot ("First screen.");
		}

















		[Test]
		public void AddTask ()
		{
			//app.Tap(c => c.Marked("Add Task"));;
			app.Tap(c => c.Id("menu_add_task"));;

			app.EnterText(c => c.Id("txtName"), "Zadace");;
			app.EnterText(c => c.Id("txtNotes"), "Zadace od male bande");;
			app.Tap(c => c.Marked("Add Task"));;

			app.Tap(c => c.Id("chkDone"));;
			app.Tap(c => c.Text("Done"));;

			return;
		}
	}
}

