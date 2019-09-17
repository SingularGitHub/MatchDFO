using System;
using System.Collections.Generic;
using System.Linq;

/**
 * Simple multiple choice question game
 * @author Michael Campbell
 * @version 1.0
 */

//Namespace
namespace MatchDFO
{
    //Class
    class Program
    {
        //Main
        static void Main(string[] args)
        {

            while (true)
            {

            ChangeTextColour(ConsoleColor.Red, "You have been stopped by a fishery officer for going over your salmon catch quota. ");
            ChangeTextColour(ConsoleColor.Red, "The fishery officer offers to let you go if you can answer the best of 5 DFO related questions.");

            Console.WriteLine("");

            int correctCount = 0;

            List<int> usedQuestions = new List<int>();

            usedQuestions.Add(31);



                for (int i = 0; i < 5; i++)

                {

                    int randomQuestion = displayQuestion(randomNumber(usedQuestions));
                    usedQuestions.Add(randomQuestion);
                    string answer = Console.ReadLine();

                    while (true)
                    {
                        if (answer.ToUpper() == "A" || answer.ToUpper() == "B" || answer.ToUpper() == "C" || answer.ToUpper() == "D")
                        {

                            break;

                        }

                        else
                        {
                            ChangeTextColour(ConsoleColor.Red, "Invalid input - Choose A, B, C or D");

                            Console.WriteLine();
                            answer = Console.ReadLine();
                        }
                    }

                    Console.Clear();
                    int correct = answerCheck(randomQuestion, answer);
                    correctCount = correctCount + correct;
                    Console.WriteLine("");

                }

                if (correctCount < 3)
                {
                    ChangeTextColour(ConsoleColor.Red, "Your DFO knowledge was too poor to be released, you're going to jail");
                    Console.WriteLine("");

                }
                else
                {
                    ChangeTextColour(ConsoleColor.Blue, "You have passed the test, you're being released");
                    Console.WriteLine("");
                }

                Console.WriteLine("Your final score is " + correctCount);

                

                while (true)
                {

                    ChangeTextColour(ConsoleColor.Yellow, "Should you hire Michael? [Y or N]");
                  

                    string answerHire = Console.ReadLine().ToUpper();

                    if (answerHire != "Y")
                    {
                        ChangeTextColour(ConsoleColor.Red, "Wrong answer, try again!");

                    }
                    else
                    {
                        ChangeTextColour(ConsoleColor.Blue, "The right choice!");
                        
                        break;
                    }

                }

                Console.WriteLine("Play Again? [Y or N]");

                string answerPlay = Console.ReadLine().ToUpper();

                if (answerPlay == "Y")
                {
                    continue;
                }
                else if (answerPlay == "N")
                {
                    return;
                }
                else
                {
                    return;
                }






            }


        }

        static int randomNumber(List<int> usedQuestions)
        {
            Random random = new Random();
            int num = usedQuestions.First();
            while (usedQuestions.ToList().Contains(num))
            {
                num = random.Next(0, 10);
            }
            return num;
        }

        static int displayQuestion(int randomNumber) {
            //Random random = new Random();

            string q1 = "What is Canada's most valuable seafood export?\n[A] Lobster \n[B] Salmon \n[C] Cod \n[D] Halibut";
            string q2 = "Approximately how many fishery officers are there in Canada?\n[A] 630 \n[B] 550 \n[C] 980 \n[D] 740";
            string q3 = "How many registered fishing vessels are there in Canada?\n[A] 22,827 \n[B] 16,598 \n[C] 17,636 \n[D] 12,827";
            string q4 = "Who is the Deputy Minister of Fisheries and Oceans Canada\n[A] Thomas Crane \n[B] Curtis Mason \n[C] Captain Salmon \n[D] Timothy Sargent";
            string q5 = "What is the most imported seafood to Canada?\n[A] Lobster \n[B] Crab \n[C] Shrimp \n[D] Tuna";
            string q6 = "How many people in Canada fish recreationally?\n[A] 2,580,000 \n[B] 1,240,000 \n[C] 3,240,000 \n[D] 5,840,000";
            string q7 = "How many vessels does the Canadian Coast Guard operate?\n[A] 119 \n[B] 325 \n[C] 75 \n[D] 254";
            string q8 = "How many helicopters does the Canadian Coast Guard operate?\n[A] 32 \n[B] 22 \n[C] 42 \n[D] 12";
            string q9 = "What year was the modern Canadian Coast Guard formed?\n[A] 1942 \n[B] 1972 \n[C] 1952 \n[D] 1962";
            string q10 = "What is the Latin motto of the Canadian Coast Guard?\n[A] Ad Maiorem Dei Gloriam \n[B] Ad verum ducit \n[C] Saluti Primum, Auxilio Semper \n[D] Animus in consulendo liber";
            string q11 = "Who is the Commissioner of the Canadian Coast Guard?\n[A] Jeffery Hutchinson \n[B] Jeffery Hall \n[C] Jeffery Sharp\n[D] Jeffrey Hartman";
            string q12 = "How many species of Salmon are there in Canada?\n[A] 4 \n[B] 5 \n[C] 6 \n[D] 8";
            string q13 = "Which species of Salmon is the largest?\n[A] Coho \n[B] Pink \n[C] Sockeye \n[D] Chinook";
            string q14 = "Which species of Salmon has the shortest lifespan?\n[A] Coho \n[B] Pink \n[C] Sockeye \n[D] Chinook";
            string q15 = "Which species of flatfish is the largest in the world? \n[A] Sole \n[B] Flounder \n[C] Pacific Halibut \n[D] Atlantic Halibut";
            string q16 = "Which species of fish is best at battle?\n[A] Flounder \n[B] Salmon Shark \n[C] Swordfish \n[D] Cod";
            string q17 = "What is the age of the oldest recorded Halibut?\n[A] 42 \n[B] 52 \n[C] 65 \n[D] 32";
            string q18 = "How many icebreakers does the Canadian Coast Guard operate?\n[A] 16 \n[B] 22 \n[C] 14 \n[D] 18";
            string q19 = "How many hovercraft does the Canadian Coast Guard operate?\n[A] 3 \n[B] 5 \n[C] 4 \n[D] 6";
            string q20 = "How many habitat officers are there in Canada 6?\n[A] 115 \n[B] 108 \n[C] 152 \n[D] 132";

            String[] questionArray = { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 };

            //Console.WriteLine(questionArray.ElementAt(randomNumber));

            ChangeTextColour(ConsoleColor.Green, questionArray.ElementAt(randomNumber));

            return randomNumber;

        }

        static void ChangeTextColour(ConsoleColor colour, string inputText)
        {

            Console.ForegroundColor = colour;
            Console.WriteLine(inputText);
            Console.ResetColor();
        }

        static int answerCheck(int randomQuestion, string answer)
        {

            int count = 0;

            if (randomQuestion == 0 && answer.ToUpper() == "A")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!"); 
                count++;

            }
            else if (randomQuestion == 1 && answer.ToUpper() == "A")

            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;

            }
            else if (randomQuestion == 2 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 3 && answer.ToUpper() == "D")

            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;

            }
            else if (randomQuestion == 4 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 5 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 6 && answer.ToUpper() == "A")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 7 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 8 && answer.ToUpper() == "D")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 9 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 10 && answer.ToUpper() == "A")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 11 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 12 && answer.ToUpper() == "D")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 13 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 14 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 15 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 16 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 17 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 18 && answer.ToUpper() == "C")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else if (randomQuestion == 19 && answer.ToUpper() == "B")
            {
                ChangeTextColour(ConsoleColor.Blue, "Correct!");
                count++;
            }
            else
            {
                ChangeTextColour(ConsoleColor.Red, "Incorrect");
            }

            return count;
        }

    }
}
