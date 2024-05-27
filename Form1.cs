using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozra3_desktop
{
	public partial class Form1 : Form
	{
		HttpClient client = new HttpClient();
		public string username;
		public string password;
		public Form1()
		{
			InitializeComponent();
			client.BaseAddress = new Uri("http://127.0.0.1:5000");
		}

		

		
		private void Login_Click(object sender, EventArgs e)
		{
			Form MainPage = new MainPage(client);
			MainPage.Show();
		}


	}
}
