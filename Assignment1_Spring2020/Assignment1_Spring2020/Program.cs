using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;      			//this sets integer variable n with value as 5.
            PrintPattern(n); 			//Calling the function PrintPattern which has been implemented below

            Console.WriteLine("**************************************************************");
            int n2 = 8; 			//this sets integer variable n2 with value as 8.
            PrintSeries(n2); 			//Calling the function PrintSeries which has been implemented below

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            string s = "09:15:35PM"; 		//this sets string variable s with value as "09:15:37PM".
            string t = UsfTime(s); 		//Calling the function UsfTime which has been implemented below
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            int n3 = 110; 				//this sets integer variable n3 with value as 110.
            int k = 11; 				//this sets integer variable k with value as 11.
            UsfNumbers(n3, k);				//Calling the function UsfNumbers which has been implemented below

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            //string[] words = new string[] { "bat", "tab", "cat" };
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            /*
            this sets string array variable words with value as follows:
                    words[0] = "abcd"
                    words[1] = "dcba"
                    words[2] = "lls"
                    words[3] = "s"
                    words[4] = "sssll"
            */
            PalindromePairs(words);			//Calling the function PalindromePairs which has been implemented below

            Console.WriteLine();
            Console.WriteLine("**************************************************************");

            int n4 = 5;  				//this sets integer variable n4 with value as 5.
            //int n4 = 4;
            Stones(n4);					//Calling the function Stones which has been implemented below

            Console.WriteLine();
            Console.WriteLine("**************************************************************");

        }

        /*
        Function   : PrintPattern 
        Description: Prints numbers in the decreasing order as we move to the next line
        Parameters : integer n = represents the number of lines to be printed in the decreasing order
        Return     : N/A (void)              
        */
        private static void PrintPattern(int n)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                if (n > 0)  					//checks if the value of n is greater than 0. 
                {
                    for (int i = n; i > 0; i--) 		//for loop to execute statements from n to 1.
                    {
                        Console.Write(i);       		//Printing the value of i in the respective iteration
                    }
                    Console.WriteLine(); 	    		//Moving the cursor to be printed in the next line
                    n--;                    			//decrementing the value of n by 1 since it has printed once.
                    PrintPattern(n);        			//Calling the function again 
                }
            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

        /*
        Function   : PrintSeries 
        Description: Prints the triangular series of numbers till n.
        Parameters : integer n2 = represents the total numbers to be printed in the series
        Return     : N/A (void)              
        */
        private static void PrintSeries(int n2)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                int sum = 1;    				//this sets integer variable sum with value as 1.
                for (int i = 2; i <= n2; i++) 			//for loop to execute statements from 2 to n2.
                {
                    Console.Write(sum + ",");  		 	//Printing the value in the integer variable sum and concatinating with a ","
                    sum = sum + i;              		//Adding the value of integer variable i to the integer variable sum
                }
            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        /*
        Function   : UsfTime 
        Description: Converts the earthly time provided in the argumeent to usftime.
        Parameters : s represents the input of earthly time in a string argument
        Return     : string              
        */
        public static string UsfTime(string s)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                DateTime d = DateTime.Parse(s); 													 //Conveting the value in string variable s to a dateTime value and storing it into the variable d.

                int usf_secs = Convert.ToInt32(TimeSpan.Parse(d.ToString("HH:mm:ss")).TotalSeconds); 
		    /*Converting the given datetime value into total number of seconds.*/

                Console.WriteLine("Total seconds:" + usf_secs);

                int usf_hr = (usf_secs / (60 * 45));	    	//Calculating the total hours in the USF world based on the total seconds
                Console.WriteLine("USF Hours: " + usf_hr);	//Printing the total hours as per the USF world.              

                int usf_min = (usf_secs - (usf_hr * 60 * 45))/ 45;		//Calculating the total mins in the USF world based on the total seconds after calculating the hours
                Console.WriteLine("USF Mins: " + usf_min);			//Printing the total remaining mins as per the USF world.
                //Console.WriteLine("USF Seconds: " + usf_seconds);

                usf_secs = (usf_secs - (usf_hr * 60 * 45)) % 45;   		//Calculating the remaining seconds
                //Console.WriteLine("USF secs: " + secs);			//Printing the total remaining seconds as per the USF world.

                string usf_time = Convert.ToString(usf_hr + ":" + usf_min + ":" + usf_secs); 
		    /*Converting the time as per the USF World into a String */

                //Console.WriteLine(usf_time); 					//Returning the string value.
                return (usf_time);
            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        /*
        Function   : UsfNumbers 
        Description: Prints USF if the number is a divisble by 3,5,7.
                    Prints US if the number is divisible by 3,5.
                    Prints SF if the number is divisible by 5,7.
                    Prints UF if the number is divisible by 3,7.
                    Prints U if the number is divisible by 3.
                    Prints S if the number is divisible by 5.
                    Prints F if the number is divisible by 7.
        Parameters: n3 represents the last number in the series
                     k represents the numbers to be displayed per line 
        Return     : N/A (void)              
        */
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                for (int i = 1; i <= n3; i++) 				//for loop to execute statements from 1 to n3
                {					
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0) 	//Checks if i is divisible by 3 or 5 or 7
                    {					
                        Console.Write("USF ");  			//Prints USF if the above condition is true
                    }					
					
                    else if (i % 3 == 0 && i % 5 == 0)  		//Checks if i is divisible by 3 or 5
                    {					
                        Console.Write("US ");				//Prints US if the above condition is true
                    }					
					
                    else if (i % 5 == 0 && i % 7 == 0)			//Checks if i is divisible by 5 or 7
                    {					
                        Console.Write("SF ");				//Prints SF if the above condition is true
                    }					
					
                    else if (i % 3 == 0 && i % 7 == 0)			//Checks if i is divisible by 3 or 7
                    {					
                        Console.Write("UF ");				//Prints UF if the above condition is true
                    }					
					
                    else if (i % 3 == 0)				//Checks if i is divisible by 3
                    {					
                        Console.Write("U ");				//Prints U if the above condition is true
                    }					
					
                    else if (i % 5 == 0)				//Checks if i is divisible by 5
                    {					
                        Console.Write("S ");				//Prints S if the above condition is true
                    }					
					
                    else if (i % 7 == 0)				//Checks if i is divisible by 7
                    {					
                        Console.Write("F ");				//Prints F if the above condition is true
                    }

                    else
                    {
                        Console.Write(i + " ");				//Prints the value of the integer i
                    }

                    if (i % k == 0)					//Checks if k is a divisor of i 
                    {
                        Console.WriteLine();				//Moving the cursor to be printed in the next line
                    }
                }

            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }


        /*
        Function   : PalindromePairs 
        Description: Checks if the concatenation of any two words in the string array form a palindrome.
        Parameters : words represent the string array
        Return     : N/A (void)              
        */
        public static void PalindromePairs(string[] words)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                for (int i = 0; i < words.Length; i++) 	  		//for loop to execute statements from 0 to the length of the string array words.
                {                                                           		
                    for (int j = 0; j < words.Length; j++) 	 	//for loop to execute statements from 0 to the length of the string array words.
                    {                                                       		
                        if (words[i] != words[j]) 			//Checks if the current reference value in the string words through integer values i and j are same.
                        {                                                   		
                            String concat_str = words[i] + words[j]; 	//Concates the current reference of the string array words through integer varaibles i and j and stores it into string variable concat_str
                            String rev_str = ""; 			//Initializes an empty string with name rev_str
                            int len = concat_str.Length - 1; 		// Integer variable len stores the values of length of the string reduced by 1.
                            while (len >= 0)    			//Checks if the integer variable len has value greater than or equal to 0
                            {                                               		
                                rev_str = rev_str + concat_str[len];    //Concats the string rev_str with the character at the position indicated by the integer value len of the string concat_str
                                len--;                                  //Reduces the value of integer variable by 1.
                            }                                               		
																					
                            if (concat_str.Equals(rev_str)) 		//Checks if the strings concat_str and rev_str is same.
                            {		
                                Console.WriteLine(concat_str);  	//Prints the value in the string variable concat_str
                                Console.WriteLine("[" + i + "," + j + "]");	//Prints the value of the integer variables i and j
                            }

                        }
                    }
                }
            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception occured while computing  PalindromePairs()");
            }
        }

        /*
        Function: Stones 
        Description: Checks if the concatenation of any two words in the string array form a palindrome.
        Parameters : n4 represents the number of total stones
        Return     : N/A (void)              
        */
        public static void Stones(int n4)
        {
            try
            {
                /* 
                 * We suspect that this block of the statement can throw 
                 * exception so we handled it by placing these statements
                 * inside try and handle the exception in the catch block
                */

                Console.WriteLine("Stones:" + n4);
                List<int> arr = new List<int>(); 		//Declaring an empty list with variable name as arr
                int player; 					//Declaring an integer variable named player
					
                if (n4 < 4) 					//Checks if the value in the integer variable n4 is less than 4
                {					
                    Console.WriteLine("Player 1 wins!!!");	//Prints "Player 1 wins!!!"
                }					
					
                else if (n4 % 4 == 0)   			//Checks if the value in the integer variable n4 is divisible by 4
                {					
                    Console.WriteLine("False");			//Prints "False"
                }

                else
                {

                    arr.Add(n4 % 4);        			//adds the reminder of the operation n4 divided by 4 as the first value in the integer array arr 
                    Console.WriteLine("Player 1 Turn(1,2,3):" + (n4 % 4));
                    player = 2;					// this sets the integer variable player to 2

                    while (arr.Sum() != n4) 			//Checks if the sum of the values in the integer array arr is not equal to 4.
                    {
                        Console.WriteLine("Player " + player + " Turn(1,2,3):");
                        int input = Convert.ToInt32(Console.ReadLine()); 	//Converts the value from the console into an integer

                        if (input < 0 || input > 3|| (arr.Sum() + input) > n4)
                        /*
                        checks the below conditions:
                        if the value stored in the variable input is less than 0    OR
                        if the value stored in the variable input is greater than 3 OR 
                        if the value stored in the variable input when added to the sum of integer array arr is more than n4  
                     */
                        {
                            Console.WriteLine("You either have entered a wrong option or the value has gone out of scope!!");
                        }
			    
                        else
                        {
                            arr.Add(input); 				//Adds the value of the integer variable input at the end of the integer list arr
                            player = (player == 1 ? 2 : 1); 		//Changes the integer value of player to 1 if its 2 or vice versa
                        }
                    }
                    Console.WriteLine("[" + String.Join(", ", arr) + "]");  	//Prints all the values in the integer list arr
                }
            }
            catch
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception occurred while computing Stones()");
            }

        }
    }
}
