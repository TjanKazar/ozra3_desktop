using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class FindTekmovanjePOSTForm : Form
	{
		private HttpClient client;
		private Tekmovanje tekma;

		public string competition_name;
		public string year;

		public FindTekmovanjePOSTForm(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			competition_name = textBox1.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			year = textBox2.Text;
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			tekma = await GetTekmovanjaAsync(client, competition_name, year);

			if (tekma != null)
			{
				Form display = new POSTForm(client, tekma);
				display.Show();
			}
			else
			{
				MessageBox.Show("No records found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		static async Task<Tekmovanje> GetTekmovanjaAsync(HttpClient client, string competitionName, string year)
		{
			string resourceUrl = $"/tekmovanje/{competitionName}/{year}";
			HttpResponseMessage response = await client.GetAsync(resourceUrl);

			if (response.IsSuccessStatusCode)
			{
				string data = await response.Content.ReadAsStringAsync();
				Tekmovanje tekma = JsonSerializer.Deserialize<Tekmovanje>(data);
				return tekma;
			}
			else
			{
				return null;
			}
		}
	}
}
