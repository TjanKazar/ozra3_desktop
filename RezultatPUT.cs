using System.Text;
using System.Text.Json;

namespace ozra3_desktop
{
	public partial class RezultatPUT : Form
	{
		HttpClient client;
		Rezultat rezultat;
		
		public RezultatPUT(HttpClient client, Rezultat rezultat)
		{
			this.client = client;
			this.rezultat = rezultat;
			
			InitializeComponent();
			name.Text = rezultat.name;
			country.Text = rezultat.country;
			age.Text = rezultat.age;
			profession.Text = rezultat.profession;
			division.Text = rezultat.division;
			points.Text = rezultat.points;
			divisionRank.Text = rezultat.divRank;
			genderRank.Text = rezultat.genderRank;
			t1.Text = rezultat.t1;
			t2.Text = rezultat.t2;
			swimTime.Text = rezultat.swim;
			runTime.Text = rezultat.run;
			bikeTime.Text = rezultat.bike;
			swimDistance.Text = rezultat.swimDistance;
			runDistance.Text = rezultat.runDistance;
			bikeDistance.Text = rezultat.bikeDistance;
			overall.Text = rezultat.overall.ToString();
			bib.Text = rezultat.bib;
		}


		private async void post_Click(object sender, EventArgs e)
		{
			// Update the properties of the rezultat object
			rezultat.name = name.Text;
			rezultat.country = country.Text;
			rezultat.age = age.Text;
			rezultat.profession = profession.Text;
			rezultat.division = division.Text;
			rezultat.points = points.Text;
			rezultat.divRank = divisionRank.Text;
			rezultat.genderRank = genderRank.Text;
			rezultat.t1 = t1.Text;
			rezultat.t2 = t2.Text;
			rezultat.swim = swimTime.Text;
			rezultat.run = runTime.Text;
			rezultat.bike = bikeTime.Text;
			rezultat.swimDistance = swimDistance.Text;
			rezultat.runDistance = runDistance.Text;
			rezultat.bikeDistance = bikeDistance.Text;
			rezultat.overall = overall.Text;
			rezultat.overallRank = overallRank.Text;
			rezultat.bib = bib.Text;

			string jsonData = JsonSerializer.Serialize(rezultat);

			try
			{
				var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PutAsync("/rezultatput", content);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to update data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void name_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
