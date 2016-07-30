using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarOwnerProject.CarOwner;

namespace CarOwnerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the car brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Please, enter the region number");
            string regionNumber = Console.ReadLine();
            GetInfoByBrand(brand);
            GetCarCount(brand);
            GetInfoByRegionNumber(regionNumber);
            Console.ReadKey();
        }
    }
}
