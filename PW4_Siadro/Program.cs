using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PW5Lib;

namespace PW4_Siadro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many houses do you want to enter?: ");
            int count = Convert.ToInt32(Console.ReadLine());

            HouseLib[] houses = new HouseLib[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Entering info for House #{i + 1} ---");

                Console.Write(" Input address: ");
                string sAddress = Console.ReadLine();

                Console.Write(" Input floors: ");
                int sFloors = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Input area: ");
                double sArea = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Input year build: ");
                int sYearBuild = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Has a garage? [Yes | No]: ");
                string answer = Console.ReadLine();
                bool sHasGarage = HasGarage(answer);

                Console.Write(" Input number of rooms: ");
                int sNumRooms = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Input material: ");
                string sMaterial = Console.ReadLine();

                HouseLib house = new HouseLib();
                house.Address = sAddress;
                house.Floors = sFloors;
                house.Area = sArea;
                house.YearBuild = sYearBuild;
                house.HasGarage = sHasGarage;
                house.NumRooms = sNumRooms;
                house.Material = sMaterial;

                houses[i] = house;
            }

            Console.WriteLine("\n========== HOUSE INFO ==========");
            foreach (HouseLib house in houses)
            {
                string isOld = house.IsOld() ? "Yes" : "No";

                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine(" Address: {0}", house.Address);
                Console.WriteLine(" Floors: {0}", house.Floors);
                Console.WriteLine(" Area: {0}", house.Area);
                Console.WriteLine(" Year build: {0}", house.YearBuild);
                Console.WriteLine(" Garage: {0}", house.HasGarage);
                Console.WriteLine(" Number of rooms: {0}", house.NumRooms);
                Console.WriteLine(" Material: {0}", house.Material);
                Console.WriteLine(" Is it an old building?: {0}", isOld);
            }
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