using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            if (temperature> 50)
            {
                int Relative;
                double Heat;
                 
                Console.WriteLine("Enter Relative Humidity");

                input = Console.ReadLine();
                Relative = int.Parse(input);

                Heat = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (Relative * 0.094));

                Console.WriteLine("The Heat Index is " + Heat);
            }
            else
            {
                int Wind;
                double Windchill;

                Console.WriteLine("Enter the Wind Speed");

                input = Console.ReadLine();
                Wind = int.Parse(input);


                Windchill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(Wind, 0.16) + 0.4275 * temperature * Math.Pow(Wind, 0.16);

                Console.WriteLine("The wind chill is " + Windchill);
            }



        }
           
        }
    }
