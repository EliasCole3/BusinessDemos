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

namespace Day2Test2
{
	public class TideAdapter : BaseAdapter<TideItem>, ISectionIndexer
	{
		List<TideItem> items;
		Activity context;

		public TideAdapter(Activity c, List<TideItem> i) : base()
		{
			items = i;
			context = c;
			BuildSectionIndex();
		}


		public override long GetItemId(int position)
		{
			return position;
		}


		public override TideItem this[int position]
		{
			get {return items [position];}
		}


		public override int Count
		{
			get {return items.Count;}
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{ 
			var item = items[position];
			View view = convertView;

			if (view == null)
			{
				view = context.LayoutInflater.Inflate (Resource.Layout.listviewLayout, null);
			}

			TextView tv1= view.FindViewById<TextView> (Resource.Id.Text1);
			tv1.Text = item.Date + "  " + item.Day;

			TextView tv2 = view.FindViewById<TextView> (Resource.Id.Text2);
			tv2.Text = item.Time;

			return view;
		}


		String[] sections;
		Java.Lang.Object[] sectionsObjects;
		Dictionary<string, int> alphaIndex; 


		public int GetPositionForSection(int section)
		{
			return alphaIndex [sections [section]];
		}


		public int GetSectionForPosition(int position)
		{
			return 1;
		}


		public Java.Lang.Object[] GetSections()
		{
			return sectionsObjects;
		}


		private void BuildSectionIndex()
		{
			alphaIndex = new Dictionary<string, int>();		// Map sequential numbers
			for (var i = 0; i < items.Count; i++)
			{
				// Use the part of speech as a key
				var key = items[i].Date.Substring(5,2); //magic happens
				if (!alphaIndex.ContainsKey(key))
				{
					alphaIndex.Add(key, i);
				} 
			}

			sections = new string[alphaIndex.Keys.Count];
			alphaIndex.Keys.CopyTo(sections, 0);
			sectionsObjects = new Java.Lang.Object[sections.Length];
			for (var i = 0; i < sections.Length; i++)
			{
				sectionsObjects[i] = new Java.Lang.String(sections[i]);
			}
		} 



	}//end of tideadapter
}

