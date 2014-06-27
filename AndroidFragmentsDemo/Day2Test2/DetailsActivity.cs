using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace Day2Test2
{
	//[Activity(Label = "Details Activity")] //previous version
	[Activity(Label = "a")] //needed an attribute, but doesn't matter what
	class DetailsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate (bundle);

			var index = Intent.Extras.GetInt ("selectedItem", 0);
			var output = Intent.Extras.GetString ("output", "error retrieving tide info");
			var details = DetailsFragment.NewInstance (index, output); 
			var fragmentTransaction = FragmentManager.BeginTransaction();
			fragmentTransaction.Add (Android.Resource.Id.Content, details);
			fragmentTransaction.Commit ();
		}
	}
}

