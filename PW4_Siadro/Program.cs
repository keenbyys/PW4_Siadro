using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW4_Siadro
{
    class Program
    {
        static void Main(string[] args)
        {
            string answearIsOld;

            Console.Write(" Input address: ");
            string address = Console.ReadLine();

            Console.Write(" Input floors: ");
            int floors = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input area: ");
            double area = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Input year build: ");
            int yearBuild = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Has a garage? [Yes | No]: ");
            string answear = Console.ReadLine();
            
            bool hasGarage = HasGarage(answear);

            Console.Write(" Input number of room: ");
            int numRooms = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Input material: ");
            string material = Console.ReadLine();

            House house = new House(address, floors, area, yearBuild, hasGarage, numRooms, material);

            bool isOld = house.IsOld();

            if (!isOld)
            {
                answearIsOld = "No";
            } else
            {
                answearIsOld = "Yes";
            }

                Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\n Info:" +
                "\n Address: {0}," +
                "\n Floors: {1}," +
                "\n Area: {2}," +
                "\n Year build: {3}," +
                "\n Garage: {4}," +
                "\n Number of room: {5}" +
                "\n Material: {6}" +
                "\n Is it an old building?: {7}", house.Address, house.Floors, house.Area, house.YearBuild, house.HasGarage, house.NumRooms, house.Material, answearIsOld);

        }

        public static bool HasGarage(string answear)
        {
            answear = answear.ToLower();

            if (answear == "yes")
            {
                return true;
            }
            if (answear == "no")
            {
                return false;
            }

            throw new ArgumentException("Invalid input. Please enter 'Yes' or 'No'.");
        }
    }
}