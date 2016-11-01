// Week 1: Individual: Tip Calculator
// Marcia L. Allen
// October 31, 2016
// Write an application that is used to determine the tip amount that should 
// be added to a restaurant charge. This program may be a console application 
// or a Windows Forms application. No matter whether you choose to develop a 
// Windows Forms application or a console application, be sure the interface 
// is professional looking and intuitive to use for the novice end user. Allow 
// the user to input the total, before taxes and the tip percentage (15% or 20%).
// Produce output showing the calculated values including the total amount due 
// for both the 15% and the 20% tips. Write appropriate methods for your solution,
// meaning develop your own void or value-returning methods in some way. Include 
// identifying information in the form of block comments at the top of each class 
// in the project (programmer name, date, program description). Include adequate
// comments throughout the program, utilize meaningful names for controls, 
// variables, fields, and forms. Include white space for readability purposes 
// in the code.

using System;

namespace TipCalculator2
{
    class TipCalculator2Program
    {
        static void Main()
        {

            // Variables Initialized
            var percent = 0.0;                  // Tip Percent Input
            var percent2 = 0.15;                // Tip Percentage Amount 2
            var percent3 = 0.20;                // Tip Percentage Amount 3
            var total = 0.0;                    // Bill Amount, before taxes
            var pay = 0.0;                      // Total Amount to Pay, including Tip
            var pay2 = 0.0;                     // Total Amount to Pay 2, including Tip
            var pay3 = 0.0;                     // Total Amount to Pay 3, including Tip
            var tip = 0.0;                      // Tip Amount
            var tip2 = 0.0;                     // Tip Amount 2
            var tip3 = 0.0;                     // Tip Amount 3

            // Welcome Message
            Console.WriteLine("\n\t\t\tWELCOME TO TIP CALCULATOR!");
            Console.WriteLine("\n\t****************************************************************");

            // Prompt for Bill Amount, before tax
            Console.Write("\n\tPlease Enter the Bill Amount, before tax: ");

            // Call Method to capture the Bill Amount, before taxes and validate input value
            total = billAmt();

            // Prompt for Percentage Amount
            Console.Write("\n\tPlease Enter the Tip Percentage(Use Decimal Point): ");

            // Call Method to capture the Tip Percentage
            percent = perAmt();

            // Call Method to Calculate the Tip Amount and Total Amount to Pay, including Tip
            amtPay(total, percent, percent2, percent3, out tip, out tip2, out tip3, out pay, out pay2, out pay3);

            // Display the Required Resulting Values
            Console.WriteLine("\n\tBILL AMOUNT & CALCULATED VALUES");
            Console.WriteLine("\n\t****************************************************************");
            Console.WriteLine("\n\tBill Amount, before taxes: \t\t\t{0:C2}", total);
            Console.WriteLine("\n\tCalculated Tip: \t\t\t\t{0:C2}", tip);
            Console.WriteLine("\n\tCalculated Tip @ 15%: \t\t\t\t{0:C2}", tip2);
            Console.WriteLine("\n\tCalculated Tip @ 20%: \t\t\t\t{0:C2}", tip3);
            Console.WriteLine("\n\tCalculated Amount to Pay, including Tip: \t{0:C2}", pay);
            Console.WriteLine("\n\tCalculated Amount to Pay, including 15% Tip: \t{0:C2}", pay2);
            Console.WriteLine("\n\tCalculated Amount to Pay, including 20% Tip: \t{0:C2}", pay3);
            Console.WriteLine("\n\t****************************************************************");

            // Display Thank you Message
            Console.WriteLine("\n\tThank you for using Tip Calculator!");

            Console.ReadKey();
        }

        // Method captures the Percentage Amount
        private static double perAmt()
        {
            // Variable for Percentage Amount
            var percent = 0.0;

            if (Double.TryParse(Console.ReadLine(), out percent))
            {
                // Validate input is a positive number
                if (percent <= 0.0)
                {
                    // Error Message if input is zero or a negative number
                    Console.WriteLine("\n\tSorry, you enter a number zero or less. Please try again.");

                    // Prompt for Percentage Amount
                    Console.Write("\n\tPlease Enter the Tip Percentage: ");

                    // Call Method again
                    percent = perAmt();
                }
            }
            else    // Validate input is numeric
            {
                // Error Message if input is not numeric
                Console.WriteLine("\n\tSorry, you entered a non-numeric value. Please try again.");

                // Prompt for Percentage Amount
                Console.Write("\n\tPlease Enter the Tip Percentage: ");

                // Call Method again
                percent = perAmt();
            }

            return percent;
        }

        // Method captures the Bill Amount, before taxes and validates proper input
        static double billAmt()
        {
            // Variable for Bill Amount, before taxes
            var total = 0.0;

            // Validate input is numeric
            if (Double.TryParse(Console.ReadLine(), out total))
            {
                // Validate input is a positive number
                if (total <= 0.0)
                {
                    // Error Message if input is zero or a negative number
                    Console.WriteLine("\n\tSorry, you enter a number zero or less. Please try again.");

                    // Prompt for Bill Amount, before tax, again
                    Console.Write("\n\tPlease Enter the Total Bill Amount, before tax: ");

                    // Call Method again
                    total = billAmt();
                }
            }
            else    // Validate input is numeric
            {
                // Error Message if input is not numeric
                Console.WriteLine("\n\tSorry, you entered a non-numeric value. Please try again.");

                // Prompt for Bill Amount, before tax, again
                Console.Write("\n\tPlease Enter the Total Bill Amount, before tax: ");

                // Call Method again
                total = billAmt();
            }

            return total;
        }

        static void amtPay(double total, double percent, double percent2, double percent3, out double tip, out double tip2, out double tip3, out double pay, out double pay2, out double pay3)
        {
            // Calculate the Tip Amount 1
            tip = total * percent;

            // Calculate the Tip Amount 1
            tip2 = total * percent2;

            // Calculate the Tip Amount 2
            tip3 = total * percent3;

            // Calculate the Total Amount to Pay 1, including Tip
            pay = total + tip;

            // Calculate the Total Amount to Pay 1, including Tip
            pay2 = total + tip2;

            // Calculate the Total Amount to Pay 2, including Tip
            pay3 = total + tip3;
        }

    }

}
