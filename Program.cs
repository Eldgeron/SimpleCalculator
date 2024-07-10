using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            bool checkIfDigit = false;
            bool checkIfAnswer = false;
            float negative = -1;

            //start the program
            Console.WriteLine("Hello, User! Welcome to Simple Calculator. Please, press Enter to continue");

            //first menu
            StartTheApplication:
            Console.WriteLine("Please choose the necessary operation and press the corresponding button: \n \"A\" >> Addition \n \"S\" >> Subtraction \n \"M\" >> Multiplication \n \"D\" >> Division \n \"E\" >> Exponentiation \n \"R\" >> Nth Root \n \"Q\" >> Quit application");

            //write the operation key and transforme to lower
            var keyChar = Console.ReadLine().ToLower();

            //Quit the application. User press the "q" button          
            if (keyChar == "q")
            {
                Console.WriteLine("See you later, aligator!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //Addition. User press the "a" button
            else if (keyChar == "a")
            {
                Console.WriteLine("You choose to add numbers. In this program we add only 2 (two) numbers. Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Cheking if first addent is digit
                do
                {
                    Console.WriteLine("Enter first addent:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float firstAddent);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else
                    {
                        checkIfDigit = false;

                        //checking if the second data is digit
                        do
                        {
                            Console.WriteLine("Enter second addent:");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float secondAddent);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else
                            {
                                checkIfDigit = false;

                                //do addition and print the result
                                float sum = firstAddent + secondAddent;
                                Console.WriteLine("You enter the first addent {0}, and the second addent {1}. \nThe sum will be: {0} + {1} = {2}", firstAddent, secondAddent, sum);
                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);
            }

            //Subtranction. User press the "s" button
            else if (keyChar == "s")
            {
                Console.WriteLine("You choose to subtract the numbers. In this program we subtract only 2 (two) numbers. Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Check if minuend is digit
                do
                {
                    Console.WriteLine("Please, enter the minuend:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float minuend);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else
                    {
                        checkIfDigit = false;
                        //Check if subtrahend is digit
                        do
                        {
                            Console.WriteLine("Please, enter the subtrahend:");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float subtrahend);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else
                            {
                                checkIfDigit = false;
                                //do subtraction and print the result
                                float difference = minuend - subtrahend;
                                Console.WriteLine("You enter the minued {0}, and the subtrahend {1}. \nThe difference will be: {0} - {1} = {2}", minuend, subtrahend, difference);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);


            }

            //Multiplication. User press the "m" button
            else if (keyChar == "m")
            {
                Console.WriteLine("You choose to multiply the numbers. In this program we multiply only 2 (two) numbers. Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Check if multiplicand is digit
                do
                {
                    Console.WriteLine("Plese, enter the multiplicand:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float multiplicand);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else
                    {
                        checkIfDigit = false;

                        //Check if the multiplier is digit
                        do
                        {
                            Console.WriteLine("Plese, enter the multiplier:");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float multiplier);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else
                            {
                                checkIfDigit = false;

                                //do multiplication and print the result
                                float prodct = multiplicand * multiplier;
                                Console.WriteLine("You enter the multiplicand {0}, and the multiplier {1}. \nThe prouct will be: {0} * {1} = {2}", multiplicand, multiplier, prodct);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);
            }

            //Division. User press the "d" button
            else if (keyChar == "d") 
            {
                Console.WriteLine("You choose to divide the number. In this program we divide only 1(one) number by 1(one) numer. Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Check if dividend is digit
                do
                {
                    Console.WriteLine("Please, enter the dividend:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float dividend);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else
                    {
                        checkIfDigit = false;

                        //Check if the multiplier is divisor
                        do
                        {
                            Console.WriteLine("Plese, enter the divisor:");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float divisor);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else if (divisor == 0)
                            {
                                Console.WriteLine("You cant divide by zero. Please, enter anothe digit:");
                                checkIfDigit= false;
                            }
                            else
                            {
                                checkIfDigit = false;

                                //do multiplication and print the result
                                float quotient = dividend / divisor;
                                Console.WriteLine("You enter the dividend {0}, and the division {1}. \nThe quotient will be: {0} / {1} = {2}", dividend, divisor, quotient);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);
            }

            //Exponentiation. User press the "e" button
            else if (keyChar == "e") 
            {
                Console.WriteLine("You choose to raise a number to a power. In this program we use Exponen (power) only from -5 to 5. Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Check if base is digit
                do
                {
                    Console.WriteLine("Please, enter the base:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float baseNum);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else
                    {
                        checkIfDigit = false;

                        //Check if the multiplier is exponent
                        do
                        {
                            Console.WriteLine("Please, enter the exponent (power):");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float exponent);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else if (exponent <= -5 || exponent >= 5)
                            {
                                Console.WriteLine("In this application we have limits. Please, choose number between -5 and 5:");
                                checkIfDigit = false;
                            }
                            else
                            {
                                checkIfDigit = false;

                                //do multiplication and print the result
                                float result = (float)Math.Pow(baseNum, exponent);
                                Console.WriteLine("You enter the base {0}, and the exponent(power) {1}. \nThe result will be: {0} ^ {1} = {2}", baseNum, exponent, result);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);
            }

            //>>Nth Root. User press the "r" button
            else if (keyChar == "r") 
            {
                Console.WriteLine("You choose root extraction. In this program we use only degree 5 . Please, press the Enter button, when you will be ready, and follow the instructions:");
                Console.ReadLine();

                //Check if radicant is digit
                do
                {
                    Console.WriteLine("Please, enter the index:");
                    checkIfDigit = float.TryParse(Console.ReadLine(), out float userIndex);
                    if (!checkIfDigit)
                    {
                        Console.WriteLine("You need to enter a digit");
                    }
                    else if (userIndex <= 0 || userIndex >= 5)
                    {
                        Console.WriteLine("In this application we have limits. Please, choose number between 1 and 5:");
                        checkIfDigit = false;
                    }
                    else
                    {
                        bool hasReminder = userIndex % 2 != 0;
                        checkIfDigit = false;
                        do
                        {
                            Console.WriteLine("Plese, enter the radicand:");
                            checkIfDigit = float.TryParse(Console.ReadLine(), out float userRadicand);
                            if (!checkIfDigit)
                            {
                                Console.WriteLine("You need to enter a digit");
                            }
                            else if (hasReminder && userRadicand < 0)
                            {
                                Console.WriteLine("You can't use ntgativ radicand with odd index. Please, enter positiv number");
                                checkIfDigit = false;
                            }
                            else if (!hasReminder && userRadicand<0)
                            {
                                float moduloUserRadicand = userRadicand * negative;
                                checkIfDigit = false;

                                //do multiplication and print the result
                                float solution = (float)Math.Pow(moduloUserRadicand, 1 / userIndex);
                                float negativeSolution = solution * negative;
                                Console.WriteLine("You enter the radicant {0}, and the index {1}. \nThere are two solutions: {1} \u221A {0} = |{2}|. |{2}| = {2}, {3}", userRadicand, userIndex, solution, negativeSolution);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                            else
                            {
                                checkIfDigit = false;

                                //do multiplication and print the result
                                float solution = (float)Math.Pow(userRadicand, 1 / userIndex);
                                Console.WriteLine("You enter the radiant {0}, and the index {1}. \nThe solution will be: {0}  \u221A {1} = {2}", userIndex, userRadicand, solution);

                                //selectiong of further actions: quit or continue
                                do
                                {
                                    Console.WriteLine("Press Q to quit the application or C to continue");
                                    string userChoose = Console.ReadLine().ToLower();
                                    if (userChoose == "q")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (userChoose == "c")
                                    {
                                        goto StartTheApplication;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                } while (checkIfAnswer == false);
                            }
                        }
                        while (checkIfDigit == false);
                    }
                }
                while (checkIfDigit == false);
            }
            //>>
            else
            {
                Console.WriteLine();
                goto StartTheApplication;
            }
        }
    }
}
