namespace ozra3_desktop
{
	public partial class Form1 : Form
	{
		public HttpClient client = new HttpClient();
		public string username;
		public string password;
		public Form1()
		{
			InitializeComponent();
			client.BaseAddress = new Uri("http://127.0.0.1:5000");
			Console.WriteLine(GetTekmovanjaAsync(client));
		}

		private void Login_Click(object sender, EventArgs e)
		{
			
			Form MainPage = new MainPage();
			MainPage.Show();
		}

		static async Task<string> GetTekmovanjaAsync(HttpClient client)
		{

			string resorceUrl = "/tekmovanja";
			HttpResponseMessage response = await client.GetAsync(resorceUrl);
			string data = await response.Content.ReadAsStringAsync();
			Console.WriteLine("GET response data: " + data);
			return data;
		}
	}

}
