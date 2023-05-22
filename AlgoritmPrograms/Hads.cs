using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Hads
    {
        int m = 1000;
        int n = 29;
        int s;

        public int GuessNumber()
        {
            if (m < n)
            {
                n = n / 2;
            }

            while (s == m)
            {
                if (m > n)
                {
                    s = (n / 2) + n;
                }
                if (s > n)
                {
                    s = (s / 2) + (n / 2);
                }
                if (s < m)
                {
                    n = s;
                }
            }
            if (m == n)
            {
                return m;
            }
            return m;

        }

        public void Guess()
        {
            Console.WriteLine("this is guessing game for number betwen 1 and 1000 and u must tell me higher or lower");

            int begin = 1;
            int end = 1000;
            int mid = (begin+end)/2;
            int counter = 1;
            Console.WriteLine(mid.ToString());
            Console.WriteLine("is it high inter 1 \n" +
                              "is it low inter  2\n" +
                              "is it your guess inter 3 ");
            var input = Convert.ToInt32(Console.ReadLine());
           


            do
            {
                if (input==3)
                {
                    Console.WriteLine("you do it with " + counter + " guess");

                    break;

                }

                if (input == 1)
                {
                    end = mid - 1;
                }

                if (input == 2)
                {
                    begin = mid + 1;
                }
                counter++;
                mid = (begin + end) / 2;
                Console.WriteLine(mid);
                Console.WriteLine("is it high inter 1 \n" +
                                  "is it low inter  2\n" +
                                  "is it your guess inter 3 ");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input != 3);
            Console.WriteLine("you do it with " + counter + " guess");

        }
        //enum words
        //{
        //    lowear,
        //    higher,
        //    bingo
        //}

        //public int GetNumberBinary(int rangedown, int rangeup)
        //{
        //    int range;
        //    Console.WriteLine("guess number in ur mind and tell me each time it is higher or lowear");

        //    range = rangeup - rangedown;

        //    if ()


        //}
        //public void answear()
        //{
        //    Random random = new Random();
        //    bool playAgain = true;
        //    int min = 1;
        //    int max = 100;
        //    int guess;
        //    int number;
        //    int guesses;
        //    String response;

        //    while (playAgain)
        //    {
        //        guess = 0;
        //        guesses = 0;
        //        response = "";
        //        number = random.Next(min, max + 1);

        //        while (guess != number)
        //        {
        //            Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        //            guess = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Guess: " + guess);

        //            if (guess > number)
        //            {
        //                Console.WriteLine(guess + " is to high!");
        //            }
        //            else if (guess < number)
        //            {
        //                Console.WriteLine(guess + " is to low!");
        //            }

        //            guesses++;
        //        }

        //        Console.WriteLine("Number: " + number);
        //        Console.WriteLine("YOU WIN!");
        //        Console.WriteLine("Guesses: " + guesses);

        //        Console.WriteLine("Would you like to play again (Y/N): ");
        //        response = Console.ReadLine();
        //        response = response.ToUpper();

        //        if (response == "Y")
        //        {
        //            playAgain = true;
        //        }
        //        else
        //        {
        //            playAgain = false;
        //        }
        //    }

        //    Console.WriteLine("Thanks for playing! ... I guess");

        //    Console.ReadKey();
        //}

    }

}