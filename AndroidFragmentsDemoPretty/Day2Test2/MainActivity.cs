namespace FragmentsDemo
{
	[Activity (Label = "FragmentsDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
		}
	}
}


