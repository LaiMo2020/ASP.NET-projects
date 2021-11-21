using System;
namespace MyInfo.Models
{
    public class Doctor
    {
        //public static string normalTemp = "All is good!";
        const double maxNormalTemp = 38.9;
        const double minNormalTemp = 35.9;

        

        public static string checkFever(double temp)
        {
            if (temp  < minNormalTemp )
                { return "you have a Hypothermia"; }

            else if (temp > maxNormalTemp)
                { return "you have a Fever!"; }
            else
            {
                return "You are good";
            }
        }

        public static double Celsius(double fahrenheit)
        {
            return 5.0 / 9.0 * (fahrenheit - 32);
        }
       
    }
}