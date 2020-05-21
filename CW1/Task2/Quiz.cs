using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2.cs
{
    class Quiz
    {



        public void QuizBegin()
        {



            while (true) //Loop to allow player to play again


            {

                
                int wrongLetters = 0;
                int totalScore = 0; //Counter to add/subtract points and total points at the end.



                //Inititlaising arrays to store questions and answers

                string[] questions = new string[5]
                {

               "The second month of the year is", "If you have made up your mind you have...", "If something is not boring it is...","Not all the time but...", "Not the same but"

                };

                string[] answers = new string[5]
                {
                "February", "Decided", "Interesting", "Sometimes", "Different"
                };


               



                //Introduction and Instructions.

                Console.WriteLine("Welcome to the spelling quiz! Press Enter to Continue!\n");
                Console.ReadLine();
                Console.WriteLine("Finish the sentences and spell the answer! Press Enter to Continue!\n");
                Console.ReadLine();
                Console.WriteLine("10 points for the correct spelling, -1 points for every wrong letter!Press Enter to Begin!\n");
                Console.ReadLine();



                //Questions and answers with user input


                Console.WriteLine(questions[0]);
                Console.ReadLine();
                

                if (Console.ReadLine() == answers[0]) //Compares user input to answer in array.
                {
                    Console.WriteLine("Correct!");
                    totalScore += 10; //+10 points if user gets answer correct



                }

                
                
            
                 else
                {
                    Console.WriteLine("Incorrect!");
                    wrongLetters -= 1; //- 1 point per wrong letter?



                    

                }

               

                Console.WriteLine(questions[1]);

                if (Console.ReadLine() == answers[1])
                {
                    Console.WriteLine("Correct!");
                    totalScore += 10;

                }




                else
                {
                    Console.WriteLine("Incorrect!");
                    


                }
                Console.WriteLine(questions[2]);

                if (Console.ReadLine() == answers[2])
                {
                    Console.WriteLine("Correct!");
                    totalScore += 10;

                }

                else
                {
                    Console.WriteLine("Incorrect!");
                    


                }



                Console.WriteLine(questions[3]);

                if (Console.ReadLine() == answers[3])
                {
                    Console.WriteLine("Correct!");
                    totalScore  +=10;

                }

                else
                {
                    Console.WriteLine("Incorrect!");
                    


                }




                Console.WriteLine(questions[4]);

                if (Console.ReadLine() == answers[4])
                {
                    Console.WriteLine("Correct! You have finished the quiz!");
                    totalScore +=10;

                }

                else
                {
                    Console.WriteLine("Incorrect! You have finished the quiz!");
                    


                }






                //Score and Play Again

                if (totalScore < 0)  //Prevents percentage being expressed as a negative if score goes below 0.
                {
                    Console.WriteLine("Your score is 0%!");

                }
                else
                {
                    Console.WriteLine("Your score is {0}", totalScore);
                    Console.WriteLine("Your score is {0}%!", (totalScore * 100) / 50); //Prints total score as percentage. 50 maximum number of points achievable.
                }

                //Correct Answers displayed if user gets some wrong.
                if (totalScore < 50)
                {
                    Console.WriteLine("Bad Luck! The correct answers were; \n February \n Decided \n Interesting \n Sometimes \n Different");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                }




                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }






            }
        }



    }
}













    



        
            
           
            
        







    
        
    


