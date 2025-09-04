using System;
namespace Modul6;
	public class Person
	{   // State
		private string name = String.Empty;
		private string address = String.Empty;
		private DateTime birthday = DateTime.Today;
		private int height;
		private double weight;

		// Constructors
		public Person() { }

		public Person(string name, string address, int height, double weight) {
			this.name = name;
			this.address = address;
			this.height = height;
			this.weight = weight;
		}

		// Methods and functions
		public bool IsTeenager()
		{
			return true;
		}

		public double BMI()
		{
			return 0;
		}

		public int DistanceFrom(double lat, double lgd)
		{
			return 0;
		}

		public void SetName(string name)
		{
			this.name = name;}

		public void SetAddress(string address)
		{
			this.address = address;}

		public void SetBirthDate(DateTime birthday)
		{
			this.birthday = birthday;
		}

		public string GetName() => name;
		public string GetAddress() => address;
		public DateTime GetBirthday() => birthday;
	}


