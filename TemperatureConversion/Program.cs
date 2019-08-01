using System;

namespace TemperatureConversion
{
    /// <summary>
    /// This program respects the absolute zero rule.
    /// If not entered a correct value within the AZ rule, the script will complain!.
    /// </summary>
    public class Temperatures
    {
        private static double _myConv, _c, _k, _f;
        private static bool _myAnswer = true;
        public static void Celsius()
        {

            do {
                Console.WriteLine("Enter the value in C to convert:");
                _myConv = Convert.ToDouble(Console.ReadLine());
                if (_myConv < -273.15)
                {
                    _myAnswer = true;
                    Program.ErrorMessage();
                }
                else
                {
                    _myAnswer = false;
                }

            } while (_myAnswer);
            _k = _myConv + 273.15;
            _f = (_myConv * 9.0 / 5.0) + 32;

            Console.WriteLine("{0} C = {1} F and {2} K", _myConv, _f, _k);
        }
        public static void Fahrenheith()
        {
            do
            {
                Console.WriteLine("Enter the value in F to convert:");
                _myConv = Convert.ToDouble(Console.ReadLine());
                if (_myConv < -459.67)
                {
                    _myAnswer = true;
                    Program.ErrorMessage();
                }
                else
                {
                    _myAnswer = false;
                }
            } while (_myAnswer);
            _c = 5.0 / 9.0 * (_myConv - 32);
            _k = 5.0 / 9.0 *(_myConv - 32) + 273;
            Console.WriteLine("{0} F = {1} C and {2} K", _myConv, _c, _k);
        }
        public static void Kelvin()
        {
            do{
            Console.WriteLine("Enter the value in K to convert:");
            _myConv = Convert.ToDouble(Console.ReadLine());
            if (_myConv < 0)
            {
                _myAnswer = true;
                Program.ErrorMessage();
            }
            else
            {
                _myAnswer = false;
            }

            } while (_myAnswer);
            _c = _myConv - 273.15;
            _f = 9.0 / 5.0 * (_myConv - 273) + 32;
            Console.WriteLine("{0} K = {1} C and {2} F", _myConv, _c, _f);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool ans = false, nContinue = false;
            do
            {
                do
                {
                    Console.WriteLine("Type <c> for Celsius,<f> for Fahrenheit and <k> for Kelvin");
                    string character = Console.ReadLine();
                    if (character == "c" || character == "C")
                    {
                        Temperatures.Celsius();
                        ans = false;
                    }
                    else if (character == "f" || character == "F")
                    {
                        Temperatures.Fahrenheith();
                        ans = false;
                    }
                    else if (character == "k" || character == "K")
                    {
                        Temperatures.Kelvin();
                        ans = false;
                    }
                    else
                    {
                        ErrorMessage();
                        ans = true;
                    }


                } while (ans);
                Console.WriteLine("Would you like to do another conversion?\nType <y> for yes and <n> for no");
                string willContinue = Console.ReadLine();
                if (willContinue == "y" || willContinue == "Y" || willContinue == "yes")
                {
                    nContinue = true;
                }
                else
                {
                    nContinue = false;
                }

            } while (nContinue);

            //Console.ReadLine(); /*Only for Windows users*/

        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Error. Wrong Input!");
        }
    }
}
