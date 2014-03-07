using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Day2Test2
{
	public class FragmentClass : ListFragment
	{

		List<TideItem> TideItems;
		List<TideItem> tideItems2;
		private int selectedPosition = -1;
		public string output = "";
		private int selectedItem;


		public static string Output
		{
			get;
			set;
		}


		public override void OnCreate (Bundle savedInstanceState)	
		{
			base.OnCreate (savedInstanceState);
			Output = "";
		}


		public override void OnActivityCreated(Bundle savedInstanceState)
		{ 
			base.OnActivityCreated(savedInstanceState);

			View detailsFrame = Activity.FindViewById<View>(Resource.Id.details);

			if (savedInstanceState != null)
			{
				selectedItem = savedInstanceState.GetInt("selectedItem", 0);
				selectedPosition = savedInstanceState.GetInt("selectedItem", 0);
			}

			if (detailsFrame != null && detailsFrame.Visibility == ViewStates.Visible)
			{
				ListView.ChoiceMode = ChoiceMode.Single;
			}

			TideItems = new List<TideItem>(); 

			const int numFields = 4;	 
			TextParser parser = new TextParser (", ", numFields);	

			var tideList = parser.ParseText (Resources.Assets.Open(@"94340322.txt"));

			foreach (string[] tideInfo in tideList) 	
			{
				TideItems.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
			}

			List<string[]> tideList2 = new List<string[]>(); 
			tideList2 = tideList;
			tideItems2 = new List<TideItem>();  
			tideList2.Sort((x, y) => String.Compare(x[0], y[0], StringComparison.Ordinal)); 

			string currentDate = "";
			string storedDate = "";
			foreach (string[] tideInfo in tideList2) 
			{										 
				if (storedDate == "") 
				{
					storedDate = tideInfo [0];
					tideItems2.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
				}

				currentDate = tideInfo [0];

				if(currentDate != storedDate)
				{
					storedDate = currentDate;
					tideItems2.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
				}

			}

			var adapter = new TideAdapter(Activity, tideItems2); 
			ListAdapter = adapter;
		}

		
		public override void OnListItemClick(ListView l, View v, int position, long id) 
		{
			output = "";
			Output = "";
			selectedPosition = position;
			ShowDetails(position);
		}
		

		private void ShowDetails(int a)
		{
			selectedItem = a;
			selectedPosition = a;
			View detailsFrame = Activity.FindViewById<View>(Resource.Id.details);

			TideItem temp1 = tideItems2 [selectedItem];
			foreach(TideItem TI in TideItems) //get out all the relevant times and tides for a clicked date
			{
				if (TI.Date == temp1.Date) 
				{
					output += TI.Time + " " + TI.Tide + "\n";
				}
			}
			Output = output;

			if (detailsFrame != null && detailsFrame.Visibility == ViewStates.Visible) //if a two fragment layout is being used
			{
				ListView.SetItemChecked (selectedItem, true); 

				var details = FragmentManager.FindFragmentById (Resource.Id.details) as DetailsFragment;  


				if (details == null || details.SelectedItem != selectedItem) //if the details instance is new, or a different item is clicked
				{
					details = DetailsFragment.NewInstance(selectedItem, output);
					var ft = FragmentManager.BeginTransaction(); 
					ft.Replace (Resource.Id.details, details);

					ft.SetTransition (FragmentTransit.FragmentFade);
					ft.Commit();	
				}
			}
			else //if a one fragment layout is being used
			{
				//launch a new new details activity using an intent, using the selectedItem
				var intent = new Intent();
				intent.SetClass (Activity, typeof(DetailsActivity));  
				intent.PutExtra("selectedItem", selectedItem);
				intent.PutExtra("output", output);
				StartActivity(intent);
			}
		}//end of ShowDetails
	}//end of FragmentClass
}//end of namespace

