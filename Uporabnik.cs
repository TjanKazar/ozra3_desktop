using System;

namespace YourNamespace
{
	public class Uporabnik
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime BirthDate { get; set; }
		public string Password { get; set; }
		public bool Accessible { get; set; }
		public int Following { get; set; } 
		public bool Admin { get; set; }

		public Uporabnik(string name, string surname, DateTime birthDate, string password, bool accessible, int following, bool admin)
		{
			Name = name;
			Surname = surname;
			BirthDate = birthDate;
			Password = password;
			Accessible = accessible;
			Following = following;
			Admin = admin;
		}
	}
}
