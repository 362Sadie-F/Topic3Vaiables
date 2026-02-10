namespace Topic3Vaiables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Mercedes Fleming";
            string declare = "Mercedes";
            string camelCase = "Fleming";
            int age = 16; // true
            int height = 160; // Inches
            int weight = 90; // lbs
            string eyeColor = "Hazel";
            string hairColor = "Brown";
            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("she's- not actually- " + height + " inches tall.");
            Console.WriteLine("She's " + weight + " pounds heavy.");
            Console.WriteLine("Her eyes are " + eyeColor + " and her hair is " + hairColor);
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I will get " + (age + weight + height) + ".");


        }
    }
}
