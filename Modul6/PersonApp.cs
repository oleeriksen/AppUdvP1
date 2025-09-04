using System;
namespace Modul6
{
	public class PersonApp
	{
		public void Run() {
          

            Person peter = new Person();

            peter.SetName("Peter");
            peter.SetAddress("byvej 123, 9876 Andeby");
            peter.SetBirthDate(new DateTime(1999, 7, 17));

            if (peter.IsTeenager())
            { }

            Person kurt = new Person("kurt", "lærkevej 12, 8000 aarhus C", 172, 69);
            kurt.SetBirthDate(new DateTime(1997, 3, 16));            

            Console.WriteLine($"{kurt.GetName()}, {kurt.GetAddress()}, Født: {kurt.GetBirthday()}");


            Person2 egon = new Person2
            {
                Name = "Egon",
                Address = "tremmely 1",
                Birthday = DateTime.Now,
                Height = 184,
                Weight = 81
            };

            Console.WriteLine($"{egon.Name}, {egon.Address}, Født: {egon.Birthday}, Højde: {egon.Height}");


        }
		
	}
}

