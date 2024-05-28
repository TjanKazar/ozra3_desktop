using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class RezultatPUTForm : Form
	{
		public Rezultat rezultat;
		public string name;
		public string age;
		public string overall;
		HttpClient client;

		public RezultatPUTForm(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			name = textBox1.Text;
			age = textBox2.Text;

			try
			{
				rezultat = await GetRezultatByNameAsync(client, name, age, overall);
				if (rezultat != null)
				{
					RezultatPUT form = new(client, rezultat);
					form.ShowDialog();
				}
				else
				{
					MessageBox.Show("Result not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async Task<Rezultat> GetRezultatByNameAsync(HttpClient client, string name, string age, string overall)
		{
			string resourceUrl = $"/rezultat_byname/{name}/{age}";
			HttpResponseMessage response = await client.GetAsync(resourceUrl);

			if (response.IsSuccessStatusCode)
			{
				string data = await response.Content.ReadAsStringAsync();
				return JsonSerializer.Deserialize<Rezultat>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
			}
			else
			{
				return null;
			}
		}

		private void RezultatPUTForm_Load(object sender, EventArgs e)
		{

		}
	}


}
