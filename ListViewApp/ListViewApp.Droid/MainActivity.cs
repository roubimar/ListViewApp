
using Android.App;
using Android.Content.PM;
using Android.OS;
using ListViewApp.All;
using ListViewApp.All.Pages;

namespace ListViewApp.Droid
{
    [Activity (Label = "ListViewApp", Icon = "@drawable/icon", Theme = "@style/MainTheme" , MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new All.App ());
        }

        public override void OnBackPressed()
        {
            ((RootPage)App.Current.MainPage).PopToRootAsync();
            return;
        }
    }
}

