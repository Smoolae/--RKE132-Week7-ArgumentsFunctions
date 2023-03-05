//Cel to Fah celsius *( 9 / 5 )+ 32
//Fah to Cel (fahrenheit - 32) * 5/9


Console.WriteLine("CF for Celsius to Fahrenheit or FC for Fahrenheit to Celsius");
string userChoice = Console.ReadLine();

if (userChoice == "CF")
{
    Console.WriteLine("You are converting Celsius to Fahrenheit");
}
else if (userChoice == "FC")
{
    Console.WriteLine("You are converting Fahrenheit to Celsius");
}
else
{
    Console.WriteLine("Enter either CF or FC");
}

Console.WriteLine("What's the temperature?");
int userTemp = Int32.Parse(Console.ReadLine());


if (userChoice == "CF")
{
    ConvertToFahrenheit(userTemp);
}
else if (userChoice == "FC")
{
    ConverToCelsius(userTemp);
}

static void ConvertToFahrenheit(int CF)
{
    Console.WriteLine($"{CF}*(9/5)+32");
}
static void ConverToCelsius(int FC)
{
    Console.WriteLine($"({FC}-32)*(5/9)");
}
