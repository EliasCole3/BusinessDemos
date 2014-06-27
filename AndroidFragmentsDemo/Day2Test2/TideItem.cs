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
	public class TideItem
	{
		public string Date { get; set;}
		public string Day { get; set;}
		public string Time { get; set;}
		public string Tide { get; set;}


		public TideItem(string a, string b, string c, string d)
		{
			Date = a;
			Day = b;
			Time = c;
			Tide = d;

		}

		public override string ToString ()
		{
			return string.Format ("[TideClass: Date={0}, Day={1}, Time={2}, Tide={3}]", Date, Day, Time, Tide);
		}
	}
}

