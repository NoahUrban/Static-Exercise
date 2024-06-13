namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32 degrees fahrenheit is {TempConverter.FahrenheitToCelsius(32)} degrees celsius");
            Console.WriteLine($"0 degrees celsius is {TempConverter.CelsiusToFahrenheit(0)} degrees fahrenheit");
        }
    }
}
