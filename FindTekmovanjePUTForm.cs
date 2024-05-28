using System.Net.Http.Json;

namespace ozra3_desktop
{
	public partial class FindTekmovanjePUTForm : Form
	{
		public HttpClient client;
		public string competition_name;
		public string year;
		public string results;

		public FindTekmovanjePUTForm(HttpClient client)
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

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			results = textBox3.Text;
		}

		

		private async void buttonSubmit_Click_1(object sender, EventArgs e)
		{
			var tekmovanje = new
			{
				competition_name,
				year,
				results
			};

			HttpResponseMessage response = await client.PostAsJsonAsync("/Tekmovanjepost", tekmovanje);
			response.EnsureSuccessStatusCode();

			MessageBox.Show("Tekmovanje added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
