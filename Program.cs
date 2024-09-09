namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 36;
            if (myNumber > 30)
            {
                Console.WriteLine($"Wow, myNumber vilket stort tal, ditt tal var {myNumber}");
            }
            else if(myNumber < 40)
            {
                Console.WriteLine("Tal mindre än 40");
            }
            else
            {
                Console.WriteLine("Märkligt");
            }

        }
    }
}
