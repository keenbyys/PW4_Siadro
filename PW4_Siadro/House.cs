using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW4_Siadro
{
    class House
    {
        private string address;
        private int floors;
        private double area;
        private int yearBuild;
        private bool hasGarage;
        private int numRooms;
        private string material;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public int YearBuild
        {
            get { return yearBuild; }
            set { yearBuild = value; }
        }
        public bool HasGarage
        {
            get { return hasGarage; }
            set { hasGarage = value; }
        }
        public int NumRooms
        {
            get { return numRooms; }
            set { numRooms = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public House(string address, int floors, double area, int yearBuild, bool hasGarage, int numRooms, string material)
        {
            Address = address;
            Floors = floors;
            Area = area;
            YearBuild = yearBuild;
            HasGarage = hasGarage;
            NumRooms = numRooms;
            Material = material;
        }

        public bool IsOld()
        {
            int currentYear = 2025;

            int calculateDiffYear = currentYear - yearBuild; 
            if (calculateDiffYear > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
