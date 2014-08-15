using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GifLibrary;

namespace GifIt_Android
{
	[Activity (Label = "GifIt_Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
	
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += async delegate {
				var root = await Utilities.GetGifList();

				Console.WriteLine(root.data[0].bitly_gif_url);
			};
		}
	}
}


