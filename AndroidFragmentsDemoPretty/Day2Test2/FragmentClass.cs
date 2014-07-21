namespace FragmentsDemo
{	
	//this class is assigned in the layout file
	public class FragmentClass : ListFragment
	{
		List<TideItem> TideItems;
		List<TideItem> tideItemsUnique;
		private int selectedPosition = -1;
		private int selectedItem;
		public string output = "";

		public static string Output
		{
			get{return output;}
			set{this.output = value;} 
		}

		public override void OnCreate (Bundle savedInstanceState)	
		{
			base.OnCreate (savedInstanceState);
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
			
			//get the tide item info from the text file
			var tideList = parser.ParseText (Resources.Assets.Open(@"94340322.txt"));

			//Create new tide items for each set of retrieved data and add them to the list
			foreach (string[] tideInfo in tideList) 	
			{
				TideItems.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
			}

			List<string[]> tideListSorted = new List<string[]>(); 
			tideListSorted = tideList; 
			tideListSorted.Sort((x, y) => String.Compare(x[0], y[0], StringComparison.Ordinal)); 

			tideItemsUnique = new List<TideItem>(); 
			
			//Filtering the list of TideItems for unique dates. 
			//The unique list is for showing the user a list of dates, and the full list is parsed when a user clicks on a particular date.
			//At the time this was written I didn't know about LINQ or other alternatives.
			string currentDate = "";
			string storedDate = "";
			foreach (string[] tideInfo in tideListSorted) 
			{				
				//for the first time
				if (storedDate == "") 
				{
					storedDate = tideInfo [0];
					tideItemsUnique.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
				}

				//every other time
				currentDate = tideInfo [0];
				if(currentDate != storedDate)
				{
					storedDate = currentDate;
					tideItemsUnique.Add (new TideItem (tideInfo [0], tideInfo [1], tideInfo [2], tideInfo [3]+" (in feet)"));
				}
			}
			var adapter = new TideAdapter(Activity, tideItemsUnique); 
			ListAdapter = adapter;
		}

		
		public override void OnListItemClick(ListView l, View v, int position, long id) 
		{
			output = "";
			selectedPosition = position;
			ShowDetails(position);
		}
		

		private void ShowDetails(int index)
		{
			index = index;
			selectedPosition = index;
			View detailsFrame = Activity.FindViewById<View>(Resource.Id.details);

			TideItem selectedTideItem = tideItemsUnique[index];
			
			//get out all the relevant times and tides for a clicked date
			foreach(TideItem TI in TideItems) 
			{
				if (TI.Date == selectedTideItem.Date) 
				{
					output += TI.Time + " " + TI.Tide + "\n";
				}
			}
			
			//if a two fragment layout is being used. detailsFrame only exists when the user's screen is large enough
			if (detailsFrame != null && detailsFrame.Visibility == ViewStates.Visible) 
			{
				ListView.SetItemChecked (index, true); 
				var details = FragmentManager.FindFragmentById (Resource.Id.details) as DetailsFragment;  

				//if the details instance is new, or a different item is clicked
				if (details == null || details.SelectedItem != index) 
				{
					details = DetailsFragment.NewInstance(index, output);
					var ft = FragmentManager.BeginTransaction(); 
					ft.Replace (Resource.Id.details, details);
					ft.SetTransition (FragmentTransit.FragmentFade);
					ft.Commit();	
				}
			}
			//if a one fragment layout is being used
			else 
			{
				//launch a new new details activity using an intent, using the index of the selected item
				var intent = new Intent();
				intent.SetClass (Activity, typeof(DetailsActivity));  
				intent.PutExtra("selectedItem", index);
				intent.PutExtra("output", output);
				StartActivity(intent);
			}
		}
	}
}

