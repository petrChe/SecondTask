using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace SecondTask
{
    class CarOwner
    {
        private string name;
        private string brand;
        private string carNumber;

        public CarOwner(string name, string brand, string carNumber) {
            this.name = name;
            this.brand = brand;
            this.carNumber = carNumber;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        public string GetCarNumber()
        {
            return this.carNumber;
        }

        public void SetName(string value)
        {
            this.name = value;
        }

        public void SetBrand(string value)
        {
            this.brand = value;
        }

        public void SetCarNumber(string value)
        {
            this.carNumber = value;
        }

        public bool nameValidation(CarOwner carOwner)
        {
            Regex nameRegex = new Regex(@"[A-Za-z]{3,15}");
            if (nameRegex.IsMatch(carOwner.GetName()))
            {
                Console.WriteLine("Name is correct");
                return true;
            }
            else
            {
                Console.WriteLine("Name is incorrect");
                return false;
            }
        }

        public bool brandValidation(CarOwner carOwner)
        {
            Regex nameRegex = new Regex(@"[A-Za-z]{3,15}");
            if (nameRegex.IsMatch(carOwner.GetBrand()))
            {
                Console.WriteLine("Brand is correct");
                return true;
            }
            else
            {
                Console.WriteLine("Brand is incorrect");
                return false;
            }
        }

        public bool carNumberValidation(CarOwner carOwner)
        {
            Regex nameRegex = new Regex(@"KZ[0-9]{3}[A-Z]{3}\d{2}");
            if (nameRegex.IsMatch(carOwner.GetCarNumber()))
            {
                Console.WriteLine("Car number is correct");
                return true;
            }
            else
            {
                Console.WriteLine("Car number is incorrect");
                return false;
            }
        }
        
        public  static List<CarOwner> GetInfoFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<CarOwner> carOwnersList = new List<CarOwner>();
            
            for(int i =0; i < lines.Length; i++)
            {
                string[] datas = new string[lines.Length];
                datas = lines[i].Split(' ');
                CarOwner carOwner = new CarOwner(datas[0], datas[1], datas[2]);
                carOwnersList.Add(carOwner);
                    
                    
                }
                
            
            //foreach(CarOwner owner in carOwnersList)
            //    {
            //    Console.WriteLine(owner.GetCarNumber());
            //}
            return carOwnersList;
        }

        public static List<string> GetInfoByBrand(string brand)
        {
            List<CarOwner> carOwnersList = CarOwner.GetInfoFromFile(@"K:\Epam C Sharp dot net\textFile2.txt");
            List<string> dataList = new List<string>();
            foreach (CarOwner carOwner in carOwnersList)
            {
                if (carOwner.GetBrand().Equals(brand)) {
                    string data = carOwner.GetName() + " " + carOwner.GetCarNumber();
                    dataList.Add(data);
                }
            }
            

            return dataList;
        }

    }
}
