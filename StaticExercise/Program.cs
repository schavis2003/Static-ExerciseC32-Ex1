namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheith(20);

            Console.WriteLine();
            Console.WriteLine($"celsius {celcius}");
            Console.WriteLine($"fahrenheith {fahrenheit}");
            

        }
    }
}
