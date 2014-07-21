namespace FragmentsDemo
{
	public class TideItem
	{
		public string Date { get; set;}
		public string Day { get; set;}
		public string Time { get; set;}
		public string Tide { get; set;}

		public TideItem(string date, string day, string time, string tide)
		{
			Date = date;
			Day = day;
			Time = time;
			Tide = tide;
		}

		public override string ToString ()
		{
			return string.Format ("[TideClass: Date={0}, Day={1}, Time={2}, Tide={3}]", Date, Day, Time, Tide);
		}
	}
}

