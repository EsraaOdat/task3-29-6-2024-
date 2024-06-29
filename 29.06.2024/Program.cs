using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _29._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            //  1 - Correct the syntax error:

            //string[] ARR = [1, 7  9  45,]
            int[] ARR = { 1, 7, 9, 45 };

            //  int arr2 = ["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };


            //	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            /////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            ///2-
            //string[] fruits = { "Tomato", "Banana", "Watermelon" };

            //// Find the index of "Banana"
            //int indexBanana = Array.IndexOf(fruits, "Banana");
            //Console.WriteLine($"Index of 'Banana': {indexBanana}");

            //// Find the index of "Tomato"
            //int indexTomato = Array.IndexOf(fruits, "Tomato");
            //Console.WriteLine($"Index of 'Tomato': {indexTomato}");
            ///////////////////////////////////////////////////////////////////////
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            for(int i=0; i <fruits.Length;i++) {
            if(fruits[i] == "Banana")
                {
                    Console.WriteLine($"Index of 'Banana': {i}");
                }
                if (fruits[i] == "Tomato")
                {
                    Console.WriteLine($"Index of 'Tomato': {i}");
                }

            }
     
            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            // 3-
            string[] favoriteFoods = { "Pizza", "Sushi", "Burger", "Pasta", "Tacos" };

            foreach (var item in favoriteFoods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < favoriteFoods.Length; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }
            Console.WriteLine("---------------------------------------------");



            string[] favoriteSports = { "Football", "Basketball", "Tennis" };
            foreach (var item in favoriteSports)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < favoriteSports.Length; i++)
            {
                Console.WriteLine(favoriteSports[i]);
            }
            Console.WriteLine("---------------------------------------------");


            string[] favoriteMovies = { "Inception", "The Shawshank Redemption", "The Dark Knight", "Interstellar" };
            foreach (var item in favoriteMovies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < favoriteMovies.Length; i++)
            {
                Console.WriteLine(favoriteMovies[i]);
            }
            Console.WriteLine("---------------------------------------------");

            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            ///4-
            Console.Write("Input three numbers : ");

            // Read the input from the user
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');

            ;

            // Convert the string array to an integer array
            string num1 = (numbers[0].Trim());
            string num2 = (numbers[1].Trim());
            string num3 = (numbers[2].Trim());



            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2) + Convert.ToInt32(num3);

            Console.WriteLine($"The sum of three numbers: {sum}");

            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            ///5-
            int Sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($" {i} ");
                    Sum = Sum + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of odd Numbers is:{Sum}");


            //////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///6-
        
            
            int[] array = new int[5] { 1, 2, 3, 4, 5};

            

            foreach (int item in array)
            {
                for (int k = 0; k < item; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }





            /////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////
            //7
          
            int j = 4;
            int num = 1; 

            for (int i = 1; i <= j; i++)
            {

                for (int k = 0; k < i; k++)
                {
                    Console.Write(num + " ");
                    num++; 
                }

                Console.WriteLine();
            }

        }
    }


}

