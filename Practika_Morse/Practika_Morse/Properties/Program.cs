using System;

namespace Practika_Morse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter phrase for encription");

            string phrase = Console.ReadLine();
            string final_morz = "";
            foreach (char let in phrase)
            {
                final_morz += Transformation.encr_morze[let] + " ";
            }
            Console.WriteLine(final_morz);
            final_morz = final_morz.Trim();

            string time_unit = "";
            foreach (char ch in final_morz)
            {
                time_unit += Transformation.time_units[ch];
            }
            time_unit = time_unit.Substring(0, time_unit.Length - 2);
            Console.WriteLine("Time-unit code");
            Console.WriteLine(time_unit);
        }
    }
}
