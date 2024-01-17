namespace HelloWorldNet8;

class Program
{
    static void Main(string[] args)
    {
        byte number = 1;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Mosh";
        bool isWorking = true;
        bool isNotWorking = false;

        var autoDetectionType = 32;

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);
        Console.WriteLine(isNotWorking);
        Console.WriteLine(autoDetectionType);
    }
}