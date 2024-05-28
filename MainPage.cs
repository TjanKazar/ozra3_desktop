using rskibbe.I18n.Models;
using rskibbe.I18n.Json;
using rskibbe.I18n.Winforms;


namespace ozra3_desktop
{
	public partial class MainPage : Form
	{
		HttpClient client;
		public MainPage(HttpClient client)
		{
			this.client = client;
			

			InitializeComponent();
		}


		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form tekmovanja_grid = new DisplayTekmovanjaForm(client);
			tekmovanja_grid.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form add_tekmovanje = new FindTekmovanjePUTForm(client);
			add_tekmovanje.Show();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			RezultatPOSTForm postForm = new RezultatPOSTForm(client);
			postForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form form = new FindTekmovanjePOSTForm(client);
			form.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form deleteForm = new DELETETekmovanje(client);
			deleteForm.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form PutForm = new RezultatPUTForm(client);
			PutForm.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form DeleteForm = new DeleteRezultat(client);
			DeleteForm.Show();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}
	}
}
