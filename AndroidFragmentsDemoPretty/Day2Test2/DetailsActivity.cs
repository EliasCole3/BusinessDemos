namespace FragmentsDemo
{
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

