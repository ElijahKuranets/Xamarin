using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace TipCalculator
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

		}

		//public override bool OnCreateOptionsMenu(IMenu menu)
  //      {
  //          MenuInflater.Inflate(Resource.Menu.menu_main, menu);
  //          return true;
  //      }

  //      public override bool OnOptionsItemSelected(IMenuItem item)
  //      {
  //          int id = item.ItemId;
  //          if (id == Resource.Id.action_settings)
  //          {
  //              return true;
  //          }

  //          return base.OnOptionsItemSelected(item);
  //      }

  //      private void FabOnClick(object sender, EventArgs eventArgs)
  //      {
  //          View view = (View) sender;
  //          Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
  //              .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
  //      }
	}
}

