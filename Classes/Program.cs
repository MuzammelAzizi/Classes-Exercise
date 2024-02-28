namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Cars();
            myCar.Make = "Bugatti";
            myCar.Model = "Veyron";
            myCar.EngineSize = "8.0LW16";
            myCar.Year = 2024;


            var lamborghini = new Cars()
            {
                Make = "Lamborghini",
                Model = "Urus",
                EngineSize = "4.0LV8",
                Year = 2020
            };

            var MercedesBenz = new Cars()
            {
                Make = "MercedesBenz",
                Model = "C63amg",
                EngineSize = "4.0V8",
                Year = 2022
            };

        
        
            var carList = new List<Cars>() { myCar, lamborghini, MercedesBenz };

            Console.WriteLine(carList);
        
            foreach (var car in carList) 
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.EngineSize} {car.Year}");
            }
        
        }



    }
}
