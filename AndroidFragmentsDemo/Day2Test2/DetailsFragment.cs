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
	internal class DetailsFragment : Fragment
	{

		public override void OnCreate (Bundle savedInstanceState)	
		{
			base.OnCreate (savedInstanceState);
		}


		public static DetailsFragment NewInstance(int selectedItem)
		{
			var detailsFragTemp = new DetailsFragment {Arguments = new Bundle()}; 
																				  //setting the bundle property of the new DetailsFragment
			detailsFragTemp.Arguments.PutInt("selectedItem", selectedItem);
			return detailsFragTemp;
		}


		public static DetailsFragment NewInstance(int selectedItem, string o) //overloaded newInstance method, for making a detailsfragment with the tideitem output, previously put into a textview in lab4
		{
			var detailsFragTemp = new DetailsFragment {Arguments = new Bundle()}; 
			detailsFragTemp.Arguments.PutInt("selectedItem", selectedItem);
			detailsFragTemp.Arguments.PutString("output", o);
			return detailsFragTemp;
		}


		public int SelectedItem
		{
			get { return Arguments.GetInt("selectedItem", 0); }
		} 


		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			string output = FragmentClass.Output;
			var scroller = new ScrollView(Activity);
			var tvText = new TextView(Activity);
			var padding = Convert.ToInt32(TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics)); 
			tvText.SetPadding(padding, padding, padding, padding);
			tvText.TextSize = 24;
			tvText.Text = output;
			scroller.AddView(tvText); 
			return scroller;
		}
	}
}

