using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


[assembly: UsesPermission("com.xamarin.")]
[assembly: UsesPermission("com.holisticware.")]

namespace Sample.XamarinForms.Droid
{
	[Activity(Label = "Sample.XamarinForms", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			#	region		Xamarin.Insights
			//---------------------------------------------------------------------------------------
			//
			//	https://insights.xamarin.com/login
			//
			//	Android
			//		Permissions:
			//			Required:
			//				[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
			//			Optional:
			//				[assembly: UsesPermission(Android.Manifest.Permission.AccessNetworkState)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.AccessWifiState)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.BatteryStats)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.BindNotificationListenerService)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.ReadExternalStorage)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.ReadPhoneState)]
			//				[assembly: UsesPermission(Android.Manifest.Permission.ReadLogs)]
			//			
			//
						Android.Content.Context app_conext = this;
						Xamarin.Insights.Initialize(Sample.XamarinForms.Constants.INSIGHTS_API_KEY, app_conext);
			// 
			//	iOS
			//		in 
			//			static void Main (string[] args)
			//		as soon as possible - before AppDelegate
			//			Xamarin.Insights.Initialize("Your API Key");
			//
			//	MacOSX
			//		in 
			//			static void Main (string[] args)
			//		as soon as possible - before AppDelegate
			//			Xamarin.Insights.Initialize("Your API Key");
			//
			//	Windows Phone
			//		in
			//			App
			//		Xamarin.Insights.Initialize("Your API Key");
			//
			//		Capabilities
			//			8		
			//					ID_CAP_IDENTIFY_DEVICE
			//			8.1 RT
			//					IN PROGRESS
			//			8.1 Silverlight
			//					UNSUPPORTED - might work
			//---------------------------------------------------------------------------------------
			#	endregion	Xamarin.Insights

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}
	}
}

