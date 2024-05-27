using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozra3_desktop
{
	public class Tekmovanje
	{
		public int id { get; set; }
		public string competition_name {  get; set; }
		public string year { get; set; }
		public string results { get; set; }

		public Tekmovanje(string competition_name, string year, string results, int id)
		{
			this.competition_name = competition_name;
			this.year = year;
			this.results = results;
			this.id = id;
		}

		public Tekmovanje(string competition_name, string year, string results)
		{
			this.competition_name = competition_name;
			this.year = year;
			this.results = results;
		}
		public Tekmovanje() { }
	}
}
