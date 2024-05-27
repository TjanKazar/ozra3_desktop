using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class Form5 : Form
	{
		private HttpClient client;
		private Tekmovanje tekma;

		public Form5(HttpClient client, Tekmovanje tekma)
		{
			InitializeComponent();
			this.client = client;
			this.tekma = tekma;

			textBox1.Text = tekma.competition_name;
			textBox2.Text = tekma.year;
			textBox3.Text = tekma.results;
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			tekma.competition_name = textBox1.Text;
			tekma.year = textBox2.Text;
			tekma.results = textBox3.Text;

			await UpdateTekmovanjeAsync(tekma);

			MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private async Task UpdateTekmovanjeAsync(Tekmovanje tekma)
		{
			string jsonData = System.Text.Json.JsonSerializer.Serialize(tekma);

			var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

			try
			{
				HttpResponseMessage response = await client.PutAsync("/Tekmovanjeput", content);

				if (response.IsSuccessStatusCode)
				{
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
	}
}
