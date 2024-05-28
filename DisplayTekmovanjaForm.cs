using System.Text.Json;

namespace ozra3_desktop
{
	public partial class DisplayTekmovanjaForm : Form
	{
		public HttpClient client;
		public List<Tekmovanje> tekmovanja = new List<Tekmovanje>();

		public DisplayTekmovanjaForm(HttpClient client)
		{
			this.client = client;
			InitializeComponent();
			LoadTekmovanjaAsync();
		}

		private async void LoadTekmovanjaAsync()
		{
			tekmovanja = await GetTekmovanjaAsync(client);
			DisplayTekmovanja(tekmovanja);
		}

		private void DisplayTekmovanja(List<Tekmovanje> tekmovanja)
		{
			dataGridView1.DataSource = tekmovanja;
		}

		static async Task<List<Tekmovanje>> GetTekmovanjaAsync(HttpClient client)
		{
			string resourceUrl = "/tekmovanja";
			HttpResponseMessage response = await client.GetAsync(resourceUrl);
			string data = await response.Content.ReadAsStringAsync();
			Console.WriteLine("GET response data: " + data);

			List<Tekmovanje> tekmovanja = JsonSerializer.Deserialize<List<Tekmovanje>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

			return tekmovanja;
		}
	}
}
