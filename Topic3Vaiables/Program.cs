namespace Topic3Vaiables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string fullname = "Mercedes Fleming";
            string firstName = "Mercedes";
            string lastName = "Fleming";
            int age = 16; // true
            int height = 160; // Inches
            int weight = 90; // lbs
            string eyeColor = "Hazel";
            string hairColor = "Brown";
            const double Tax = 0.13;
            double item1Tax, item1Price = 10.00;
            item1Tax = item1Price * Tax;
            Console.WriteLine("Let's talk about " + fullname + ".");
            Console.WriteLine("Her last name, " + lastName + ", is from her father.");
            Console.WriteLine("she's- not actually- " + height + " inches tall."); //turn from inches to cm
            Console.WriteLine(firstName + " is " + weight + " pounds heavy."); //turn from lbs to kg
            Console.WriteLine("Her eyes are " + eyeColor + " and her hair is " + hairColor);
            Console.WriteLine("    ");
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I will get " + (age + weight + height) + ".");
            Console.WriteLine("    ");
            Console.WriteLine("The tax on this item is " + item1Tax.ToString("C"));
        }
    }
}
