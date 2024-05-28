using System;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace ozra3_desktop
{
	public partial class RezultatPOSTForm : Form
	{
		HttpClient client;
		public string namevar;
		public string countryvar;
		public string agevar;
		public string professionvar;
		public string divvar;
		public string pointsvar;
		public string divisionRankvar;
		public string genderRankvar;
		public string t1var;
		public string t2var;
		public string swimTimevar;
		public string runTimevar;
		public string bikeTimevar;
		public string swimDistancevar;
		public string runDistancevar;
		public string bikeDistancevar;
		public string overallvar;
		public string overallRankvar;
		public string bibvar;

		public RezultatPOSTForm(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
		}

		private async void post_Click(object sender, EventArgs e)
		{
			// Collect data from form controls
			namevar = name.Text;
			countryvar = country.Text;
			agevar = age.Text;
			professionvar = profession.Text;
			divvar = division.Text;
			pointsvar = points.Text;
			divisionRankvar = divisionRank.Text;
			genderRankvar = genderRank.Text;
			t1var = t1.Text;
			t2var = t2.Text;
			swimTimevar = swimTime.Text;
			runTimevar = runTime.Text;
			bikeTimevar = bikeTime.Text;
			swimDistancevar = swimDistance.Text;
			runDistancevar = runDistance.Text;
			bikeDistancevar = bikeDistance.Text;
			overallvar = overall.Text;
			overallRankvar = overallRank.Text;
			bibvar = bib.Text;

			// Create the data object to send
			var rezultat = new
			{
				swim = swimTimevar,
				division = divvar,
				run = runTimevar,
				name = namevar,
				profession = professionvar,
				country = countryvar,
				age = agevar,
				run_distance = runDistancevar,
				bib = bibvar,
				state = "",  // You might want to add a corresponding field or set it appropriately
				bike = bikeTimevar,
				gender_rank = genderRankvar,
				overall = overallvar,
				swim_distance = swimDistancevar,
				overall_rank = overallRankvar,
				points = pointsvar,
				t2 = t2var,
				bike_distance = bikeDistancevar,
				t1 = t1var,
				div_rank = divisionRankvar
			};

			string jsonData = JsonSerializer.Serialize(rezultat);


			var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

			try
			{
				HttpResponseMessage response = await client.PostAsync("/rezultatpost", content);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Result added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to add result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}