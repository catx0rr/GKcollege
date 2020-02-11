using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace zodiac
{

    class Car
    {
        public static void alpha(string name)
        {
            name = Convert.ToString(new Regex("^[a-zA-Z \f\n\r\t\v]*$"));
            return;
        }
        string xcarType = "";

        public void drive()
        {
            Console.WriteLine("Driving " + this.xcarType);

            Console.WriteLine("inside Car " + this.passengers(30).ToString());
        }

        public Car(string carType)
        {
            this.xcarType = carType;

            Console.WriteLine("Init....");
        }

        private int passengers(int num)
        {
            return num;
        }

        public static int getNumber()
        {
            return 1;
        }

        public static string FormatNumber(string money)
        {
            return "$ " + money;
        }
    }
}
