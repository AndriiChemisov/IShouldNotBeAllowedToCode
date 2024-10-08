namespace meme
{
    internal class ThisIsAmerica
    {

        public class The2ndAmendment
        {
            //Empty list to ensure that you have a 1/6 chance to get arrested (shamelessly stolen from Russian Roulette)
            private static List<int> funnyReference = new List<int> { 0, 0, 0, 0, 0, 0 };

            //Method to decide which thought wil lresut in rights violation
            public static int DecideThought()
            {
                Random copLogic = new Random();

                //Deciding which thought will result in violation of YOUR RIGHTS
                return copLogic.Next(0, 5);
            }

            //Creating a modified list of thoughts with one bad thought
            public static List<int> CreateCopThoughts(int dirtyThought)
            {
                //Changing the value of the thought so that it can trigger the condition in the loop below
                funnyReference[dirtyThought] = 1;

                return funnyReference;

            }

            public static void ThePunchline()
            {
                Console.WriteLine("So anyway, I started blasting");
            }


            static void Main(string[] args)
            {
                //Local variable (I could avoid this, but I need an indexer)
                int copThoughts = 0;

                //Fail condition - not necessary at all, but I really wanted another variable with a funny name. Sue me.
                bool amIUnderArrest = false;

                int theFunny = DecideThought();

                List<int> dirtyThoughts = CreateCopThoughts(theFunny);

                //To monitor which thought it is
                Console.WriteLine("Cop will do the funny on thought #" + theFunny);
                Thread.Sleep(5000);
                Console.Clear();

                do
                {
                    Console.WriteLine("\"Am I under arrest, officer?\"");
                    Thread.Sleep(1000);

                    if (dirtyThoughts[copThoughts] == 0)
                    {

                        Console.WriteLine("Cop is having a thonk");
                        Thread.Sleep(3000);

                        //Monitoring which thought we iterated over
                        Console.WriteLine($"Cop thonked thought #{copThoughts} ");
                        Thread.Sleep(100);

                        Console.WriteLine("\"Nah, man. We good.\"");
                        Thread.Sleep(100);

                        Console.WriteLine("\"Thank you officer, have a good day\"");
                        Thread.Sleep(100);

                        //Ensuring your rights ARE violated at some point and the loop does not become an infinite one
                        copThoughts++;
                        Console.WriteLine("Press any button to experience America again");
                        Console.ReadKey();
                        Console.Clear();

                    }

                    else
                    {
                        Console.WriteLine($"Cop thonked thought #{copThoughts} ");
                        Thread.Sleep(100);

                        Console.WriteLine("\"Yes, lmao\"");
                        Thread.Sleep(100);


                        //The joke that started it all
                        Parallel.Invoke(The2ndAmendment.ThePunchline);

                        //exit condition
                        amIUnderArrest = true;

                    }

                } while (amIUnderArrest == false);
            }
        }
    }
}
