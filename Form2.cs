using System.Text.Json;

namespace ozra3_desktop
{
	public partial class Form2 : Form
	{
		public HttpClient client;
		public List<Tekmovanje> tekmovanja = new List<Tekmovanje>();

		public Form2(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
			client.BaseAddress = new Uri("http://127.0.0.1:5000");

			// Load data when the form is initialized
			LoadTekmovanjaAsync();
		}

		private async void LoadTekmovanjaAsync()
		{
			tekmovanja = await GetTekmovanjaAsync(client);
			DisplayTekmovanja(tekmovanja);
		}

		private void DisplayTekmovanja(List<Tekmovanje> tekmovanja)
		{
			// Set the DataSource of the DataGridView to the list of Tekmovanje objects
			dataGridView1.DataSource = tekmovanja;
		}

		static async Task<List<Tekmovanje>> GetTekmovanjaAsync(HttpClient client)
		{
			string resourceUrl = "/tekmovanja";
			HttpResponseMessage response = await client.GetAsync(resourceUrl);
			string data = await response.Content.ReadAsStringAsync();
			Console.WriteLine("GET response data: " + data);

			// Deserialize the JSON response into a list of Tekmovanje objects
			List<Tekmovanje> tekmovanja = JsonSerializer.Deserialize<List<Tekmovanje>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

			return tekmovanja;
		}
	}
}
