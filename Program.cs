namespace meme
{
    internal class ThisIsAmerica
    {

        public class The2ndAmendment
        {

            public static void ThePunchline()
            {
                Console.WriteLine("So anyway, I started blasting");
            }
        }
        static void Main(string[] args)
        {
            int[] funnyReference = new int[6] { 0, 0, 0, 0, 0, 0 };

            Random copLogic = new Random();

            int copDecision = copLogic.Next(0, 6);

            Console.WriteLine("Cop will do the funny on thought " + copDecision);
            Thread.Sleep(1000);

            funnyReference[copDecision] = 1;

            bool amIUnderArrest = false;

            int copThoughts = 0;
            //ABOBA

            do
            {
                Console.WriteLine("\"Am I under arrest, officer?\"");
                Thread.Sleep(1000);
                switch (funnyReference[copThoughts])
                {
                    case 0:
                        Console.WriteLine("Cop is having a thonk");
                        Thread.Sleep(3000);
                        Console.WriteLine($"Cop thonked thougt {funnyReference[copThoughts]} ");
                        Console.WriteLine("\"No\"");
                        Console.WriteLine("\"Thank you officer, have a good day\"");
                        copThoughts++;
                        Console.WriteLine("Press any button to experience America again");
                        Console.ReadKey();
                        continue;

                    case 1:
                        Console.WriteLine("\"Yes, lmao\"");
                        Parallel.Invoke(The2ndAmendment.ThePunchline);
                        amIUnderArrest = true;
                        break;
                }
            } while (amIUnderArrest == false);
        }
    }
}
