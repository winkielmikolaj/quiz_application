namespace quiz_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables needed to operate a quiz
            Console.WriteLine("Try to use capital letters");
            string q1 = "What is a capital of  germany";
            string a1 = "Berlin";

            string q2 = "What is 2+2";
            string a2 = "4";

            string q3 = "What color is mixing blue and yellow";
            string a3 = "Green";
            //score
            int score = 0;
            //app logic
            Console.WriteLine(q1);
            string userAnswers1 = Console.ReadLine();
            if (userAnswers1 == a1)
            {
                score = score + 1;
            }
            else
            {
                Console.WriteLine($"Very bad, correct answer is {a1}");
                //score = score -1;
            }

            Console.WriteLine(q2);
            string userAnswers2 = Console.ReadLine();
            if (userAnswers2 == a2)
            {
                Console.WriteLine("Correct!");
                score = score +1;
            }
            else
            {
                Console.WriteLine($"Very bad, correct answer is {a2}");
                //score = score -1;
            }


            Console.WriteLine(q3);
            string userAnswers3 = Console.ReadLine();
            if (userAnswers3 == a3)
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine($"Very bad, correct answer is {a3}");
                //score = score - 1;
            }

            if (score == 3)
            {
                Console.WriteLine($"Excellent! You got all the answers right! {score}/3");
            }
            else if (score > 0)
            {
                Console.WriteLine($"Good Job, but keep learning! {score}/3");
            }
            else
            {
                Console.WriteLine($"Try again and see if u can get some answers right next time {score}/3");
            }



            Console.ReadKey();
        }
    }
}
