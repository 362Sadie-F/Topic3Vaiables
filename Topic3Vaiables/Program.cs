namespace Topic3Vaiables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string fullname = "Mercedes Fleming";
            string declare = "Mercedes";
            string camelCase = "Fleming";
            int age = 16; // true
            int height = 160; // Inches
            int weight = 90; // lbs
            string eyeColor = "Hazel";
            string hairColor = "Brown";
            Console.WriteLine("Let's talk about " + fullname + ".");
            Console.WriteLine("Her last name, " + camelCase + ", is from her father.");
            Console.WriteLine("she's- not actually- " + height + " inches tall."); //turn from inches to cm
            Console.WriteLine(declare + " is " + weight + " pounds heavy."); //turn from lbs to kg
            Console.WriteLine("Her eyes are " + eyeColor + " and her hair is " + hairColor);
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I will get " + (age + weight + height) + ".");


        }
    }
}
