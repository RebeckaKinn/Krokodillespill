namespace Krokodillespill
{
    internal class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("       KROKODILLESPILL");
            Console.WriteLine("Fyll inn med < > = eller avslutt");
            Console.WriteLine("        med andre tegn.");
            Console.WriteLine(" ");
            Gameplay();
        }

        static void Gameplay()
        {
            Random numb = new Random();
            int number1 = numb.Next(1, 12);
            int number2 = numb.Next(1, 12);

            //10 mellomrom for å sentrere
            Console.WriteLine($"          {number1} _ {number2}");
            Console.WriteLine($"          Score: {sum}");
            CheckInput(number1, number2);


        }

        static void CheckInput(int left, int right)
        {
            bool rightAnswer = false;
            var input = Console.ReadLine();

            if (left == right && input == "=")
            {
                rightAnswer = true;
                Score(rightAnswer);
                Gameplay();
            }
            else if (left > right && input == ">" || left < right && input == "<")
            {
                rightAnswer = true;
                Score(rightAnswer);
                Gameplay();
            }
            else
            {
                GameOver();
            }
        }

        static int Score(bool answer)
        {
            if (answer)
            {
                sum++;
            }
            else
            {
                sum--;
            }
            return sum;
        }

        static void GameOver()
        {
            Console.WriteLine($"      Din score ble: {sum}");
        }

    }
}