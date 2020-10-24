using MyCarApp.models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public enum CarType { SUV, Kombi, Kleinwagen, Cabrio};

namespace MyCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            var isActive = true;
            while (isActive)
            {
            {


                Car car = new Car();

                Console.WriteLine("Wählen Sie ein Auto");
                Console.WriteLine("1 - Sportauto");
                Console.WriteLine("2 - Normales Auto");

                string MyUserInput = Console.ReadLine();


                switch (MyUserInput)
                {
                    case "1":
                        Console.WriteLine("Deine Auswahl ist: Sportauto");
                        break;
                    case "2":
                        Console.WriteLine("Deine Auswahl ist: Normales Auto");
                        break;
                    default:
                        Console.WriteLine("Deine Auswahl ist ungültig");
                        break;
                }

                Console.WriteLine("Mögliche Autotypen sind: ");
                foreach (var value in Enum.GetValues(typeof(CarType)))
                    Console.WriteLine(value);

                Console.Write("Wähle ein Autotyp: ");
                string TypeInput = Console.ReadLine();

                switch (TypeInput.ToLower())
                {
                    case "suv":
                        Console.WriteLine("Deine Auswahl ist: SUV");
                        break;
                    case "kombi":
                        Console.WriteLine("Deine Auswahl ist: Kombi");
                        break;
                    case "kleinwagen":
                        Console.WriteLine("Deine Auswahl ist: Kleinwagen");
                        break;
                    case "cabrio":
                        Console.WriteLine("Deine Auswahl ist: Cabrio");
                        break;
                    default:
                        Console.WriteLine("Bitte überprüfe deine Eingabe");
                        break;
                }
                car.CarType = TypeInput;

                Console.Write("Hersteller: ");
                MyUserInput = Console.ReadLine();
                car.Manufacturer = MyUserInput;
                Console.Write("Modell: ");
                MyUserInput = Console.ReadLine();
                car.Name = MyUserInput;
                Console.Write("Baujahr: ");
                MyUserInput = Console.ReadLine();
                car.BuildYear = MyUserInput;
                Console.Write("Farbe: ");
                MyUserInput = Console.ReadLine();
                car.Color = MyUserInput;

                Console.WriteLine("\nAutotyp: " + car.CarType + "\nHersteller: " + car.Manufacturer + "\nModell: " + car.Name + "\nBaujahr: " + car.BuildYear + "\nFarbe: " + car.Color);
                Console.WriteLine("Speichern? Y / N");
                MyUserInput = Console.ReadLine();

                if (MyUserInput.ToLower() == "y")
                {
                    cars.Add(car);
                    String[] carsAsArray = GetArrayOfAllCars(cars);
                        var counter = 0;
                        foreach (var element in carsAsArray)
                        {
                            Console.WriteLine(carsAsArray[counter]); /// -> for each ....
                            counter++;
                        }
                }
                else
                {
                    Console.WriteLine("Das Auto wurde nicht gespeichert");
                }
                
                Console.WriteLine("Neues Auto hinzufügen? Y / N");
                MyUserInput = Console.ReadLine();

                if(MyUserInput.ToLower() != "y")
                {
                        isActive = false;
                }
                }
            }
        }
        private static String[] GetArrayOfAllCars(List<Car> cars)
        {
            String[] carsStr = new string[cars.Count];
            for (int i = 0; i < cars.Count; i++)
            {
                String car = cars[i].toString();
                carsStr[i] = car;
                Console.WriteLine(carsStr[i]);
            }
            return carsStr;
        }

    }
}
