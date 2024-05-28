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
	public partial class DeleteRezultat : Form
	{
		public string Name;
		public string Bib;

		HttpClient client;
		public DeleteRezultat(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			Name = name.Text;
			Bib = bib.Text;
			HttpResponseMessage response = await client.GetAsync($"/rezultat_byname/{Name}/{Bib}");
			if (response.IsSuccessStatusCode)
			{
				// Get the ID of the result from the response
				string responseData = await response.Content.ReadAsStringAsync();
				Rezultat result = JsonSerializer.Deserialize<Rezultat>(responseData);
				int id = result.id;

				// Call the API to delete the result by ID
				HttpResponseMessage deleteResponse = await client.DeleteAsync($"/rezultatdelete/{id}");

				if (deleteResponse.IsSuccessStatusCode)
				{
					MessageBox.Show("Result deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Failed to delete result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Result not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
