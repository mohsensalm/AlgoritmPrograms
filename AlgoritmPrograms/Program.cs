// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AlgoritmPrograms;


var nums = new   [] {1,1,2};
var permutaion = new Permutations();
//permutaion.Permute(nums);
permutaion.MyPermute(nums);





var per = new Permutations();
per.PermuteUnique(nums);

































//List<int> o = new List<int>{4,32,5 ,63}      ;

//var permutation = new Permutations();
//permutation.Permute(o);


















//ArrayExample ex = new ArrayExample();
//ex.DifrenceBetweanTwoList();


//int[] o = {1, 4, 3, 5};

//Permutations p = new Permutations();

//p.permution( o);



//EightQueensSolver solver = new EightQueensSolver();
//solver.Solve();



//Seke s = new Seke();    
//s.DynamicCoin();
//Daramad d = new Daramad();
//d.Tax();


//Seke s = new Seke();    
//s.Coins(50);

//Random rnd = new Random();
//var target=  rnd.Next(1, 1001);
//var respone =   Math.Log(1000);



//Hads h = new Hads();
//h.Guess();


//int resualt = 0, counter = 0, five, ten, twenty;
//for (twenty = 1; twenty < 2; twenty++)
//{
//    for (ten = 1; ten < 3; ten++)
//    {
//        for (five = 1; five < 5; five++)
//        {
//            resualt = (twenty * 20) + (ten * 10) + (five * 5);
//            if (resualt == 50)
//            {
//                Console.WriteLine("twenty:" + twenty + "" + "ten:" + ten + "" + "five:" + five);
//                counter++;
//                break;
//            }
//        }
//    }
//}





















//Console.WriteLine(m);
//Console.WriteLine("if your guess higher write 1 or if your guess lowear write 2 and if your guess matchs write 3");
//var Answear = Convert.ToInt32(Console.ReadLine());
//counter1++;

//while (gameContinue)
//{
//    if (Answear == 1)
//    {
//        var s = m + 1;
//        m = (s + end) / 2;
//    }

//    if (Answear == 2)
//    {
//        var d = m - 1;
//        m = (begin + d) / 2;

//    }
//    else
//    {
//        Answear = 3;
//        gameContinue = false;
//    }
//    int mid = (begin + end) / 2;

//}
//Console.WriteLine(counter1 + " times I tried for finding your number ");




//while (guess == target )
//{
//    var guess = Convert.ToInt32(Console.ReadLine());


//    if (guess > mid)
//    {
//        Console.WriteLine("Guess is high");



//    }
//    if (guess < target)
//    {
//        Console.WriteLine("Guess is low");
//    }
//    else
//    {
//        Console.WriteLine("bingo u find it ");
//    }



//int min = 1;    // minimum number
//int max = 1000;    // maximum number 
//int middle = 500;  // middle number 
//int counter = 0;
//string name, input;
//int guess_number;

//Console.WriteLine("Hello, this is a game that finding the number of in your mind. If you want to play so let me know you! ");
//name = Console.ReadLine();
//Console.WriteLine("Awesome welcome to the game " + name + " guess a number between " + min + " and " + max + " Please! ");
//Console.WriteLine("Is your guess " + middle + " ?\nIf it's your guess then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");
//input = Console.ReadLine();
//guess_number = Convert.ToInt32(input);
//Console.WriteLine(" You select " + guess_number + " so, ");

//do
//{
//    counter += 1;
//    if (guess_number == 2)
//    {
//        min = middle + 1;
//    }
//    else if (guess_number == 1)
//    {
//        max = middle - 1;
//    }
//    else if (guess_number != 1 || guess_number != 2 || guess_number != 0)
//    {
//        Console.WriteLine(" Please write 0, 1 or 2 " + name);
//    }

//    middle = (min + max) / 2;
//    Console.WriteLine("Is your guess " + middle +
//                      " ?\nIf it's your guess then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");
//    Console.WriteLine(counter + " times I tried for finding your number ");


//    input = Console.ReadLine(); // let user key in new value.
//    guess_number = Convert.ToInt32(input);

//} while (guess_number != 0);


