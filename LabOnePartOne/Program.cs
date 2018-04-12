using System;

namespace LabOnePartOne
{
    class Program
    {


        static void Main(string[] args)
        {
            //Ask for user to input numbers
            Console.WriteLine("Please enter a three digit number");
            string NumOne = Console.ReadLine();
            int FirstNumber;
            bool NumOneBool = int.TryParse(NumOne, out FirstNumber);

            Console.WriteLine("Please enter another three digit number");
            string NumTwo = Console.ReadLine();
            int SecondNumber;
            bool NumTwoBool = int.TryParse(NumTwo, out SecondNumber);



            if (NumOneBool && NumTwoBool)
            {
                Task(NumOne, NumTwo);
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }



        }
        static void Task(string NumOne, string NumTwo)
        {
            //Single out the digits in each three digit number
            int NumOneHundreds = NumOne[0];
            int NumOneTens = NumOne[1];
            int NumOneOnes = NumOne[2];

            int NumTwoHundreds = NumTwo[0];
            int NumTwoTens = NumTwo[1];
            int NumTwoOnes = NumTwo[2];


            //Add digits in respecive places and set them equal to eachother
            if (((NumOneHundreds + NumTwoHundreds) == (NumOneTens + NumTwoTens)) && (NumOneOnes + NumTwoOnes) == (NumOneTens + NumTwoTens))
                Console.WriteLine(true);
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}