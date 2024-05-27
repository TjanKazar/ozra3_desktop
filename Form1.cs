using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class Form1 : Form
	{
		private HttpClient client = new HttpClient();

		public Form1()
		{
			InitializeComponent();
			client.BaseAddress = new Uri("http://127.0.0.1:5000");
		}

		private async void Login_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			string password = textBox2.Text;

			HttpResponseMessage response = await client.GetAsync($"/uporabnik/{username}/{password}");

			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();
				dynamic userData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);


				if (userData.accessible == true)
				{
					Form MainPage = new MainPage(client);
					MainPage.Show();
				}
				else
				{
					MessageBox.Show("You do not have access to this feature", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
