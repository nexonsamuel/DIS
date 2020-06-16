using System;
using System.Globalization;

namespace Console_DIS
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string team_1 = "India";
            string team_2 = "America";
            int goal_1 = 5;
            int goal_2 = 3;
            Console.WriteLine("Match "+team_1 + " - " + team_2 + 
            " ended with result "+goal_1+ " - "+goal_2);
           // Chapter 4
            double pi = 3.14;
            Console.WriteLine(pi);
            double M_pi = Math.PI;
            Console.WriteLine(M_pi);

            // Chapter 5
            Console.WriteLine("Current:" + DateTime.Now);
            Console.WriteLine("Today's Date:" + DateTime.Today);            
            Console.WriteLine("Month:" + DateTime.Now.Month);
            Console.WriteLine("Year:" + DateTime.Now.Year);
            Console.WriteLine("Hours:" + DateTime.Now.Hour);    
            Console.WriteLine("Minutes:" + DateTime.Now.Minute);
            Console.WriteLine("Seconds:" + DateTime.Now.Second);

            
            Console.WriteLine("Device Name:" + Environment.MachineName);
            Console.WriteLine("Is 64-bit System:" + Environment.Is64BitOperatingSystem);
            Console.WriteLine("User Name:" + Environment.UserName);

            //Chapter 6
            Console.WriteLine("Today is "+ DateTime.Today.ToLongDateString());
            Console.WriteLine("I will start learning from " 
                        + DateTime.Today.AddDays(1).ToLongDateString());
            
            DateTime B_day = new DateTime(1994, 6, 30);
            Console.WriteLine("BirthDay:" +B_day.ToLongDateString());

             Random randomNumbers = new Random();
             Console.WriteLine("Throwing Dice once");

            Console.WriteLine("Throws: " + randomNumbers.Next(1, 6+1));
            //Console.WriteLine("Throws: " + System.Random.Next(1, 6+1));
            Console.WriteLine("Throws: " + randomNumbers.Next(1, 6+1));
            Console.WriteLine("Throws: " + randomNumbers.Next(1, 6+1));

            
            Console.WriteLine("Throwing Dice twice");
            Console.WriteLine("Throws: " + randomNumbers.Next(1, 6+1) + 
                            " - " + randomNumbers.Next(1, 6+1));

            Console.WriteLine("Path to Desktop: " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            //Chapter 7
            String Original_text = "This is the last day of our acquaintance";
            Console.WriteLine("Original Text:" + Original_text);
            Console.WriteLine("Number of chars:" + Original_text.Length);
            Console.WriteLine("In Uppercase:" + Original_text.ToUpper());
            Console.WriteLine("Does it contain word \"last\":" + Original_text.Contains("last"));
            int num = 1234;
            Console.WriteLine("Output of number:" + num);
            Console.WriteLine("Output of text:" + num.ToString());

            double amount = 1234.56;
            double anotherAmount = 789;
            int wholeNum = 1234567;

            Console.WriteLine("Separating thousands and millions + money to cents");
            Console.WriteLine(amount.ToString("N2"));
            Console.WriteLine(anotherAmount.ToString("N2"));
            Console.WriteLine(wholeNum.ToString("N0"));
            
            int wholeNumber = 1234567;
            double decimalNumber = 1234567.89;

            CultureInfo czech    = new CultureInfo("cs-CZ");
            CultureInfo american = new CultureInfo("en-US");

            Console.WriteLine("Whole number - Czech: "    + wholeNumber.ToString("N0", czech));
            Console.WriteLine("Whole number - American: " + wholeNumber.ToString("N0", american));
            Console.WriteLine("Decimal number - Czech: "    + decimalNumber.ToString("N2", czech));
            Console.WriteLine("Decimal number - American: " + decimalNumber.ToString("N2", american));

            //Chapter 8
            Console.WriteLine("Enter a line:(And then press enter)");
            //String message = Console.ReadLine();
            String message = "Welcome to the world of Nexon Samuel!!";
            Console.WriteLine(message);
            
            Console.WriteLine("How old are you?");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = 26;
            Console.WriteLine("Your age:" + age);

            Console.WriteLine("Enter year of your birth:");
            //int dob = Convert.ToInt32(Console.ReadLine());
            int dob = 1994;
            int current_age = DateTime.Now.Year - dob;
            Console.WriteLine("This year you are/will be:" + current_age);

            Console.WriteLine("Enter a number:");
            //num = Convert.ToInt32(Console.ReadLine());
            num = 1994;
            Console.WriteLine("Adding 10 the number:" + (num +10) );

            try
            {
                Console.WriteLine("Enter the first number:");
                //int num1 = Convert.ToInt32(Console.ReadLine());
                int num1 = 25;
                Console.WriteLine("Enter the second number:");
                //int num2 = Convert.ToInt32(Console.ReadLine());
                int num2 = 50;
                Console.WriteLine("Sum of the entered numbers:" + (num1 + num2));
                
            }
            catch(Exception)
            {
                Console.WriteLine("Incorrect input - Cannot calculate");
            }

            //Chapter 9
            Console.WriteLine("Enter a decimel number");
            //double dec = Convert.ToDouble(Console.ReadLine());
            double dec = 1.25;
            Console.WriteLine("You have entered the number:" + dec);

            Console.WriteLine("Enter the first number:");
            //double dec1 = Convert.ToDouble(Console.ReadLine());
            double dec1 = 5.5;
            Console.WriteLine("Enter the second number:");
            //double dec2 = Convert.ToDouble(Console.ReadLine());
            double dec2 = 2;
            Console.WriteLine("Sum:" + (dec1 + dec2));
            Console.WriteLine("Difference:" + (dec1 - dec2));
            Console.WriteLine("Product:" + (dec1 * dec2));
            Console.WriteLine("Quotient:" + (dec1 / dec2));
            Console.WriteLine("Remainder:" + (Convert.ToInt32(dec1) % Convert.ToInt32(dec2)));

            Console.WriteLine("Enter an angle in degrees:");
            //double deg = Convert.ToDouble(Console.ReadLine());
            double deg = 30;
            Console.WriteLine("Sine of the angle:" + (Math.Sin(deg * Math.PI/180)));

            Console.WriteLine("Enter a positive number:");
            //double pos_num = Convert.ToDouble(Console.ReadLine());
            double pos_num = 2;
            Console.WriteLine("Squareroot of the number:" + (Math.Sqrt(pos_num)));

        
            //Chapter 10
            Console.WriteLine("Enter the amount euros:");
            //double euro_amt = Convert.ToDouble(Console.ReadLine());
            double euro_amt = 3.79;
            Console.WriteLine("Euro-USD exchange rate:");
            //double exch_rate = Convert.ToDouble(Console.ReadLine());
            double exch_rate = 1.24;
            Console.WriteLine("Amount in dollars:"+ (euro_amt*exch_rate));

            Console.WriteLine("Enter the no. of pieces (Book):");
            //double num_of_books = Convert.ToDouble(Console.ReadLine());
            double num_of_books = 3;
            Console.WriteLine("Enter the no. of pieces (DVD):");
            //double num_of_dvds = Convert.ToDouble(Console.ReadLine());
            double num_of_dvds = 1;

            double per_book = 29.8;
            double per_dvd = 9.9;
            double shipment = 25;
            double total = (num_of_books * per_book) + (num_of_dvds * per_dvd) + shipment;

            Console.WriteLine("Order Calculation:");
            Console.WriteLine("Books:" + (num_of_books * per_book));
            Console.WriteLine("DVDs:" + (num_of_dvds * per_dvd));
            Console.WriteLine("Shipment:" + shipment);
            Console.WriteLine("Total:" + total);

            Console.WriteLine("Enter the customer price of the product:");
            //double cust_price = Convert.ToDouble(Console.ReadLine());
            double cust_price = 481;
            Console.WriteLine("Enter the Merchant commision(percentage):");
            //double mer_comm = Convert.ToDouble(Console.ReadLine());
            double mer_comm = 35;
            Console.WriteLine("Enter the Distributor commision(percentage):");
            //double dis_comm = Convert.ToDouble(Console.ReadLine());
            double dis_comm = 20;
            
            double price_after_comm_sub = (cust_price * (1 - mer_comm / 100.0)) * (1 - dis_comm / 100.0);
            double mer_Income = cust_price - (cust_price * (1 - mer_comm/100.0));
            double dis_Income = (cust_price * (1 - mer_comm / 100.0)) - price_after_comm_sub;
            double prod_Income = price_after_comm_sub;

            Console.WriteLine("Income division");
            Console.WriteLine("----------------");
            Console.WriteLine("Merchant: " + mer_Income);
            Console.WriteLine("Distributor: " + dis_Income);
            Console.WriteLine("Producer: " + prod_Income);


            Console.WriteLine("Enter (decimal) amount in dollars: ");
            //double round_amt = Convert.ToDouble(Console.ReadLine());
            double round_amt = 3216.492;
            Console.WriteLine("Nearest:" + Math.Round(round_amt));
            Console.WriteLine("Up:" + Math.Ceiling(round_amt));
            Console.WriteLine("Down:" + Math.Floor(round_amt));

            
            Console.WriteLine("Enter customer price of the product: ");
            //double cust_price_with_VAT = Convert.ToDouble(Console.ReadLine());
            double cust_price_with_VAT = 2841.37;
            Console.WriteLine("Enter VAT percentage: ");
            //double VAT_percent = Convert.ToDouble(Console.ReadLine());
            double VAT_percent = 493.13;
            double divisor = 1 + VAT_percent / 100.0;
            
            double price_without_VAT = Math.Round(cust_price_with_VAT /divisor,2);
            Console.WriteLine("Price without VAT: "+ price_without_VAT);
            Console.WriteLine("VAT:" + (cust_price_with_VAT - price_without_VAT));

            //Chapter 11
            try
            {
            Console.WriteLine("Enter a date(mm/dd/yyyy):");
            //DateTime Entered_Date = Convert.ToDateTime(Console.ReadLine());
            DateTime Entered_Date = Convert.ToDateTime("30/06/1994");
            DateTime Following_Date = Entered_Date.AddDays(1) ;
            DateTime Previous_Date = Entered_Date.AddDays(-1) ;
            Console.WriteLine("Entered Day:" + Entered_Date.ToLongDateString());
            Console.WriteLine("Entered Day:" + Following_Date.ToLongDateString());
            Console.WriteLine("Entered Day:" + Previous_Date.ToLongDateString());
            }
             catch (Exception)
            {
            // Treating incorrect input
            Console.WriteLine("Incorrect input");
            }

            
            Console.WriteLine("Enter a date(mm/dd/yyyy):");
            //DateTime Single_month = Convert.ToDateTime(Console.ReadLine());
            DateTime Single_month = Convert.ToDateTime("15/02/1994");

            int entered_year = Single_month.Year;
            int entered_month = Single_month.Month;
            DateTime first_of_the_month = new DateTime(entered_year,entered_month,1);
            DateTime last_of_the_month = first_of_the_month.AddMonths(1).AddDays(-1);
            Console.WriteLine("Corresponding Month: from "+ first_of_the_month + " to " + last_of_the_month);

            Console.WriteLine("Enter a date(mm/dd/yyyy):");
            //DateTime Single_month = Convert.ToDateTime(Console.ReadLine());
            DateTime quater_date = Convert.ToDateTime("15/05/1994");
            int entered_yr = quater_date.Year;
            int entered_mon = quater_date.Month;

            int num_of_quarter = (entered_mon +2)/3;
            int month_of_the_quarter_start = (num_of_quarter * 3) - 2;
            DateTime firstdayofQuarter = new DateTime(entered_yr,month_of_the_quarter_start,1);
            DateTime lastdayofQuarter = firstdayofQuarter.AddMonths(3).AddDays(-1);

            Console.WriteLine("Corresponding quarter:" + num_of_quarter );
            Console.WriteLine("From" + firstdayofQuarter + " to " + lastdayofQuarter);
            
            Console.WriteLine("BirthDay: " + B_day);
            Console.WriteLine("Today: " + DateTime.Today);
            Console.WriteLine("Days Spent on earth:" + (DateTime.Today - B_day));
            Console.WriteLine("Years Spent on earth:" + (DateTime.Today - B_day)/365);

            //Chapter 12
            Console.WriteLine("Signed whole numbers");
            Console.WriteLine("--------------------");
            Console.WriteLine("sbyte:  " + sbyte.MinValue + " to " +sbyte.MaxValue);
            Console.WriteLine("short:  " + short.MinValue + " to " + short.MaxValue);
	        Console.WriteLine("int:    " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("long:   " + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Unsigned whole numbers");
            Console.WriteLine("----------------------");
            Console.WriteLine("byte:   " + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("ushort: " + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("unit:   " + uint.MinValue + " to " + uint.MaxValue);
            //Console.WriteLine("ulong:  " + ulong.MinValue + " to " + ­ulong.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Basic decimal numbers");
            Console.WriteLine("---------------------");
            Console.WriteLine("float:  " + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " to " + double.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Exact decimal numbers");
	        Console.WriteLine("---------------------");
            Console.WriteLine("decimal:  " + decimal.MinValue + " to " + decimal.MaxValue);

            //Chapter 13
            Console.WriteLine();
            Console.WriteLine("Enter a number:");
            //num = Convert.ToInt32(Console.ReadLine());
            num = 17;
            num -=1;
            Console.WriteLine("Decreased by 1:" + num);
            num +=1;
            Console.WriteLine("Back again:" + num);

            Console.WriteLine();
            String names = "";
            Console.WriteLine("Family Siblings:");
            Console.WriteLine("---------------------");
            names += "Nexon" + Environment.NewLine;
            names += "Benson" + Environment.NewLine;
            names += "Anson" + Environment.NewLine;
            names += "Jenson" + Environment.NewLine;
            Console.WriteLine(names);

            //Chapter 15
            String password = "Samuel";
            Console.WriteLine("Enter the password:");
            //String entered_pwd = Console.ReadLine();
            String entered_pwd = "Samuel";

            if (entered_pwd == password)
            Console.WriteLine("Welcome to the world of Coding!!");
            else
            Console.WriteLine("Sorry you are kicked out!!");

            Console.WriteLine("Logic Reversed:");
            Console.WriteLine("Enter the password:");
            //entered_pwd = Console.ReadLine();
            entered_pwd = "Nexon";

            if (entered_pwd != password)
            Console.WriteLine("Sorry you are kicked out!!");
            else            
            Console.WriteLine("Welcome to the world of Coding!!");

            Console.WriteLine("Enter a string");
            //String word_len = Console.ReadLine();
            String word_len = "Nexon";

            if(word_len.Length > 4)
            Console.WriteLine("Word is long");
            else            
            Console.WriteLine("Word is too short");

            Console.WriteLine("Enter a number");
            //int sign_num = Convert.ToInt32(Console.ReadLine());
            int sign_num = 0;

            if(sign_num > 0)
            Console.WriteLine("Number is positive");
            else if(sign_num == 0)
            Console.WriteLine("Number is neither positive or negitive");
            else        
            Console.WriteLine("Number is negitive");

            Console.WriteLine("Enter a number:");
            //sign_num = Convert.ToInt32(Console.ReadLine());
            sign_num =15;

            if((sign_num%2) == 0)
            Console.WriteLine("It is an even number.");
            else
            Console.WriteLine("It is an odd number.");

            Console.WriteLine("Enter the first name:");
            //String name_1 = Console.ReadLine();
            String name_1 = "Nexon";
            Console.WriteLine("Enter the second name:");
            //String name_2 = Console.ReadLine();
            String name_2 = "Nexon";

            if(name_1.ToUpper() == name_2.ToUpper())
            Console.WriteLine("Names are same.");
            else
            Console.WriteLine("Names are not same.");


            Console.WriteLine("Enter the first number:");
            //int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_1 = 12;
            Console.WriteLine("Enter the second number:");
            //int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_2 = 12;

            if(num_1 > num_2)
            Console.WriteLine(num_1 + " is greater");
            else if(num_1 < num_2)
            Console.WriteLine(num_2 + " is greater");
            else
            Console.WriteLine("Both are equal");

            //Chapter 16
            Console.WriteLine("Enter the image name:");
            //String file_name = Console.ReadLine();
            String file_name = "nexon";

            if(!file_name.EndsWith(".png"))
            file_name += ".png";
            Console.WriteLine("File Name:" + file_name);


            Console.WriteLine("Enter the deadline:");
            //DateTime deadline = Convert.ToDateTime(Console.ReadLine());
            DateTime deadline = Convert.ToDateTime("30/06/1994");

            if (deadline < DateTime.Today)
            Console.WriteLine("Error, you have entered date in the past!");

            //Chapter 17
            Console.WriteLine("Enter the username:");
            //String username = Console.ReadLine();
            String username = "Nexon";
            Console.WriteLine("Enter the password:");
            //password = Console.ReadLine();
            password = "nexon72";

            if(username == "nexonsamuel" && password == "nexon72")
            Console.WriteLine("Logging in!!");
            else
            Console.WriteLine("Could not log you in!!");


            //Chapter 18
            Console.WriteLine("Enter the goals scored by first team:");
            //goal_1 = Convert.ToInt32(Console.ReadLine());
            goal_1 = 3;
            Console.WriteLine("Enter the goals scored by second team:");
            //goal_2 = Convert.ToInt32(Console.ReadLine());
            goal_2 = 5;

            if(goal_1 > goal_2)
            Console.WriteLine("Team 1 won!!");
            else if (goal_2 > goal_1)
            Console.WriteLine("Team 2 won!!");
            else
            Console.WriteLine("Match ended as a draw!!");

            Console.WriteLine("Enter the first number:");
            //num_1 = Convert.ToInt32(Console.ReadLine());
            num_1 = 13;
            Console.WriteLine("Enter the second number:");
            //num_2 = Convert.ToInt32(Console.ReadLine());
            num_2 = 10;
            Console.WriteLine("Enter the third number:");
            //int num_3 = Convert.ToInt32(Console.ReadLine());
            int num_3 = 15;

            if (num_1 < num_2 && num_1 < num_3)
            Console.WriteLine(num_1 + "is the minimum");
            else if (num_2 < num_1 && num_2 < num_3)
            Console.WriteLine(num_2 + " is the minimum");
            else
            Console.WriteLine(num_3 + " is the minimum");

            Console.WriteLine("Enter the value of a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            Console.WriteLine("Enter the value of b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            int b = 3;

            if (a!=0)
            Console.WriteLine("Solution of X:" + (-(b))/a);
            else
            {
                if(b==0)
                Console.WriteLine("It has infinite solutions");
                else
                Console.WriteLine("Does not have a solution");

            }

            Console.WriteLine("Enter the value of a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            a = 2;
            Console.WriteLine("Enter the value of b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            b = 3;
            Console.WriteLine("Enter the value of c:");
            //int c = Convert.ToInt32(Console.ReadLine());
            int c = 5;
            int d = (b*b) - (4*a*c);

            if(d < 0)
            Console.WriteLine("Equation does not have a real solution");

            if(d > 0)
            {
                double pos_res =  (-b + Math.Sqrt(d))/2*a;
                double neg_res =  (-b - Math.Sqrt(d))/2*a;
                Console.WriteLine("The equation has two solutions:");
                Console.WriteLine(pos_res);
                Console.WriteLine(neg_res);
            }

            if(d == 0)
            {
                  double res = (-b/2*a);
                  Console.WriteLine("The equation has a single solution:" + res);

            }


            //Chapter 20
            Console.WriteLine("Enter the number of repetations:");
            //int j = Convert.ToInt32(Console.ReadLine());
            int j = 6;
            Console.WriteLine("Enter the message to be repeated:");
            //message = Console.ReadLine();
            message = "Welcome to the world of coding!!";

            for(int i=0;i<j;i++)
            Console.WriteLine(message);

            //Chapter 22
            for (int i=1;i<11;i++)
            {
             int j_sqr = i*i;   
            Console.WriteLine(i+ ":" + j_sqr);
            }
            
            //Chapter 23

            bool ok;
            do{
                Console.WriteLine("Enter the password:");
                String entered_password = Console.ReadLine();
                ok = entered_password == "Nexon";
            }while(!ok);

            Console.WriteLine("Welcome to world of Coding!!");

            //Chapter 25 ==> Moon Landing Problem

/******************************************************************************************/
            Console.WriteLine("Hello World!!");

            int age = 46;
            int height = 61;
            int max_rate = 220 - age;
            Console.WriteLine("I am years " + age +" old,my max heart rate is " + max_rate +
             " and I am " + height + " inches tall.");
       
 
        }
    }
}