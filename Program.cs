namespace quiz_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string q1 = "what is a capital of  germany";
            string a1 = "berlin";

            string q2 = "what is 2+2";
            string a2 = "4";

            string q3 = "what color is mixing blue and yellow";
            string a3 = "green";

            int score = 0;

            Console.WriteLine(q1);
            string userAnswers1 = Console.ReadLine();
            if (userAnswers1 == a1)
            {
                score = score + 1;
            }
            else
            {
                Console.WriteLine($"nooo correwct answer is {a1}");
                score = score -1;
            }

            Console.WriteLine($"u completed quiz your score is {score}");



            Console.ReadKey();
        }
    }
}
