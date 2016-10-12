using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWorkDeliverable
{
    class PreWorkCode
    {
      static void Main(string[] args)
       {
            while (true) { //initiates an infinite loop to keep prompting the user if they wish to continue (yes or no)




                //***Notes on initial veriables********************************************************
                //strNum is used for converting myNum to a string (need this to insert 0 in the 0 index position)
                //for the situation when myNum ends in zero
                //for every other situation where myNum does not end in zero, reverseNum will be printed to the user
                string strNum = "";
                int reverseNum = 0;
                //**************************************************************************************




                Console.WriteLine("Please enter a positive integer to reverse.");
                while (true) { //initiates an infinite loop to keep prompting user with exceptions, if applicable
                    try { 
                        int myNum = Convert.ToInt32(Console.ReadLine()); //tests if myNum is an integer
                        if (myNum >= 0) { //tests if myNum is positive
                            bool zeroAtStart = false; //initializes a boolean that will be true only if myNum is divisible by zero
                            if (myNum % 10 == 0) {//tests if myNum is divisible by zero
                                myNum += 1; //upon myNum being divisible by zero, we add 1 to ensure all digits are retained through the reverse loop
                                zeroAtStart = true;
                            }




                            //***this is the loop that will reverse myNum*****************************
                            while (myNum > 0) { 
                                int rem = myNum % 10; //extracts the last digit
                                reverseNum = reverseNum * 10 + rem; // starts building up reverseNum
                                myNum = myNum / 10; //shaves off the last digit
                            }//***********************************************************************




                            //**if myNum ends in zero, this gets executed*****************************
                            if (zeroAtStart == true) { 
                               strNum = Convert.ToString(reverseNum);
                               strNum = strNum.Remove(0,1).Insert(0, "0");//replaces index "0", which will be a 1, with 0
                               Console.WriteLine(strNum); //this will be the reversed number (the final result) the user will see
                            }//***********************************************************************




                          break;
                        }
                        else
                        {
                            Console.WriteLine("Try again, enter a positive integer.");//instructs user to enter in something positive, if applicable
                        }
                    }
                    catch (Exception e)//executes if myNum isn't an integer
                    {
                        Console.WriteLine("Try again, enter an integer.");//instructs user to enter an integer, if applicable
                    }
                }
                if ( strNum == ""){//will print rverseNum if the last digit of myNum was not zero
                    Console.WriteLine(reverseNum);
                }       
                Console.WriteLine("Would you like to continue? (Press any key for yes or N for no)");
                string answer = Console.ReadLine();//prompts user if they want to continue
                 if (answer == "N") {
                        break;
                    }     
            }
                
            // Keeps the console window open in debug mode-running into this issue with Visual Studio for some reason
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
