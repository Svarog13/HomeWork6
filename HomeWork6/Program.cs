Console.WriteLine("Select the temperature scale (1 - Celsius or 2 - Fahrenheit): ");

double choise = double .Parse(Console.ReadLine());

if (choise == 1)
{
    Console.WriteLine("Entered the temperature in Сelsies: ");
    int celsius = int.Parse(Console.ReadLine());

    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"Temperature in graduces Farenhates: {fahrenheit}.");
}
else if (choise == 2)
{
    Console.WriteLine("Entered the temperature in Сelsies: ");
    double farinhait = double.Parse(Console.ReadLine());

    double celsius = (farinhait - 32) * 5 / 9;

    Console.WriteLine($"Temperature in graduces Celsius: {celsius}");   

}
else
{
    Console.WriteLine("You entered wrong choise Jeddi ");
}
