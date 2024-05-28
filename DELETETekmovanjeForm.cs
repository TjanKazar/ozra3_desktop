using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class DELETETekmovanje : Form
	{
		private HttpClient client;
		private int tekma_id;

		public string competition_name;
		public string year;

		public DELETETekmovanje(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			competition_name = textBox1.Text;
			year = textBox2.Text;

			tekma_id = await GetTekmovanjaAsync(client, competition_name, year);

			if (tekma_id != null)
			{
				await deleteTekmovanjeAsync(tekma_id);

				

			}
			else
			{
				MessageBox.Show("No records found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		static async Task<int> GetTekmovanjaAsync(HttpClient client, string competitionName, string year)
		{
			string resourceUrl = $"/tekmovanje/{competitionName}/{year}";
			HttpResponseMessage response = await client.GetAsync(resourceUrl);

			if (response.IsSuccessStatusCode)
			{
				string data = await response.Content.ReadAsStringAsync();
				Tekmovanje tekma = JsonSerializer.Deserialize<Tekmovanje>(data);
				return tekma.id;
			}
			else
			{
				return -1;
			}
		}

		public async Task deleteTekmovanjeAsync(int tekma_id)
		{
			string jsonData = JsonSerializer.Serialize(tekma_id);

			try
			{
				HttpResponseMessage response = await client.DeleteAsync("/tekmovanjedelete/" + tekma_id);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
