using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace MissingVectorDrawableCompat
{
	[Activity (
		Label = "MissingVectorDrawableCompat", 
		MainLauncher = true, 
		Icon = "@mipmap/icon",
		Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			SetSupportActionBar(FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar));

			SupportActionBar.Title = "Testing";
		}
	}
}


