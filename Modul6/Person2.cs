using System;
namespace Modul6
{
	public class Person2
	{   // State
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public DateTime Birthday { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }

        //Methods
        public bool IsTeenager() { return true; }

        public double BMI()
        {
	        return Weight * Weight / Height;
        }
	}
}
