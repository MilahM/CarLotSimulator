using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car -DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - DONE

            var carsInList = new Carlot();

            var kia = new Car();

            kia.Year = 2022;
            kia.Make = "Kia";
            kia.Model = "Sorento";
            kia.EngineNoise = "Grinding";
            kia.HonkNoise = "Beep";
            kia.IsDrivable = true;

            carsInList.CarsInLot.Add(kia);


            var dodge = new Car(2023, "Dodge", "Ram", "Rattling", "Honk", true);

            carsInList.CarsInLot.Add(dodge);

            var honda = new Car()
            {
                Year = 2020,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Clicking",
                HonkNoise = "Beep",
                IsDrivable = false
            };

            carsInList.CarsInLot.Add(honda);

            kia.MakeEngineNoise(kia.EngineNoise);
            kia.MakeHonkNoise(kia.HonkNoise);

            dodge.MakeEngineNoise(dodge.EngineNoise);
            dodge.MakeHonkNoise(dodge.HonkNoise);

            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);

            Console.WriteLine("---------------------");

            foreach (var car in carsInList.CarsInLot)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

       

    }
}
