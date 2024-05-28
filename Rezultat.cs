using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozra3_desktop
{
	public class Rezultat
	{
		public int id { get; set; }
		public string swim { get; set; }
		public string division { get; set; }
		public string run { get; set; }
		public string name { get; set; }
		public string profession { get; set; }
		public string country { get; set; }
		public string age { get; set; }
		public string runDistance { get; set; }
		public string bib { get; set; }
		public string State { get; set; }
		public string bike { get; set; }
		public string genderRank { get; set; }
		public string overall { get; set; }
		public string swimDistance { get; set; }
		public string overallRank { get; set; }
		public string points { get; set; }
		public string t2 { get; set; }
		public string bikeDistance { get; set; }
		public string t1 { get; set; }
		public string divRank { get; set; }

		public Rezultat(int id, string swim, string division, string run, string name, string profession, string country, string age, string runDistance, string bib, string state, string bike, string genderRank, string overall, string swimDistance, string overallRank, string points, string t2, string bikeDistance, string t1, string divRank)
		{
			this.id = id;
			this.swim = swim;
			this.division = division;
			this.run = run;
			this.name = name;
			this.profession = profession;
			this.country = country;
			this.age = age;
			this.runDistance = runDistance;
			this.bib = bib;
			State = state;
			this.bike = bike;
			this.genderRank = genderRank;
			this.overall = overall;
			this.swimDistance = swimDistance;
			this.overallRank = overallRank;
			this.points = points;
			this.t2 = t2;
			this.bikeDistance = bikeDistance;
			this.t1 = t1;
			this.divRank = divRank;
		}

		public Rezultat()
		{
		}

		public Rezultat(string swim, string division, string run, string name, string profession, string country, string age, string runDistance, string bib, string state, string bike, string genderRank, string overall, string swimDistance, string overallRank, string points, string t2, string bikeDistance, string t1, string divRank)
		{
			this.swim = swim;
			this.division = division;
			this.run = run;
			this.name = name;
			this.profession = profession;
			this.country = country;
			this.age = age;
			this.runDistance = runDistance;
			this.bib = bib;
			State = state;
			this.bike = bike;
			this.genderRank = genderRank;
			this.overall = overall;
			this.swimDistance = swimDistance;
			this.overallRank = overallRank;
			this.points = points;
			this.t2 = t2;
			this.bikeDistance = bikeDistance;
			this.t1 = t1;
			this.divRank = divRank;
		}
	}
}
