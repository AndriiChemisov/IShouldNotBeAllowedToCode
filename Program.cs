namespace meme
{
    internal class ThisIsAmerica
    {

        public class The2ndAmendment
        {
            //Empty list of 6 thoughts to be changed later
            private static List<int> funnyReference = new List<int> { 0, 0, 0, 0, 0, 0 };

            //Method to decide which thought wil lresut in rights violation
            public static int DecideThought()
            {
                Random copLogic = new Random();

                //Deciding which thought will result in violation of YOUR RIGHTS
                int copDecision = copLogic.Next(0, 6);

                //Changing the value of the thought so that it can trigger the condition in the loop below
                return copDecision;
            }

            //Creating a modified list of thoughts with one bad thought
            public static List<int> CreateCopThoughts()
            {
                funnyReference[DecideThought()] = 1;

                return funnyReference;

            }
            //Empty list to ensure that you have a 1/6 chance to get arrested (shamelessly stolen from Russian Roulette)

            //Setting the exit condition(not necessary at all, I just wanted to write more funny names)

            //Setting the index to iterate over the list of thoughts
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

                List<int> dirtyThoughts = CreateCopThoughts();

                //To monitor which thought it is
                Console.WriteLine("Cop will do the funny on thought " + theFunny);
                Thread.Sleep(1000);

                do
                {
                    Console.WriteLine("\"Am I under arrest, officer?\"");
                    Thread.Sleep(1000);

                    if (dirtyThoughts[copThoughts] == 0)
                    {

                        Console.WriteLine("Cop is having a thonk");
                        Thread.Sleep(3000);

                        //Monitoring which thought we iterated over
                        Console.WriteLine($"Cop thonked thought {copThoughts + 1} ");
                        Thread.Sleep(100);

                        Console.WriteLine("\"Nah, man. We good.\"");
                        Thread.Sleep(100);

                        Console.WriteLine("\"Thank you officer, have a good day\"");
                        Thread.Sleep(100);

                        //Ensuring your rights ARE violated at some point and the loop does not become an infinite one
                        copThoughts++;
                        Console.WriteLine("Press any button to experience America again");
                        Console.ReadKey();

                    }

                    else
                    {
                        Console.WriteLine($"Cop thonked thought {copThoughts + 1} ");
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
