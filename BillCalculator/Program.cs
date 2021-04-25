using System;

namespace BillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // INPUT
            Console.Write("Input Customer ID: ");
            string customerId = Console.ReadLine().ToUpper();
            while (String.IsNullOrEmpty(customerId))
            {
                Console.Write("Please Input Customer ID: ");
                customerId = Console.ReadLine().ToUpper();   
            }
            
            Console.Write("Input Customer NAME: ");
            string customerName = Console.ReadLine().ToUpper();
            while (String.IsNullOrEmpty(customerName))
            {
                Console.Write("Please Input Customer NAME: ");
                customerName = Console.ReadLine().ToUpper();   
            }

            Console.Write("Input Unit Consumed: ");
            decimal unitConsumed;
            string unitInputted = Console.ReadLine();
            bool checkUnitInputted = decimal.TryParse(unitInputted, out unitConsumed);
            Console.WriteLine();
            
            // CHECK FOR CORRECT UNIT
            while (!checkUnitInputted)
            {
                Console.Write("Please Input the CORRECT Unit Consumed: ");
                unitInputted = Console.ReadLine();
                checkUnitInputted = decimal.TryParse(unitInputted, out unitConsumed);
                Console.WriteLine();
            }
  
            decimal billCharged = 0M;
            decimal surChargeAmount = 0M;
            decimal netAmount = 0M;
            double perUnitCharge = 0;

            // PROCESS
            if (unitConsumed > 0 && unitConsumed < 200)
            {
                perUnitCharge = 1.2;
            }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                perUnitCharge = 1.5;
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                perUnitCharge = 1.8;
            }
            else
            {
                perUnitCharge = 2.0;
            }

            // BILL CALCULATION
            billCharged = unitConsumed * Convert.ToDecimal(perUnitCharge);

            // OUTPUT
            Console.WriteLine("Customer ID NO: {0}", customerId);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Unit Consumed: {0}", unitConsumed);

            if (billCharged > 300)
            {
                surChargeAmount = 0.15M * billCharged;
                netAmount = billCharged + surChargeAmount;

                Console.WriteLine("Amount charges @ Rs{0} per unit: {1}", perUnitCharge, billCharged);
                Console.WriteLine("Surcharge Amount: {0}", surChargeAmount);
                Console.WriteLine("Net Amount paid by the customer: {0}", netAmount);
            }
            else if(billCharged < 100)
            {
                Console.WriteLine("The Bill for {0} Unit Consumed is Lower than the Minimum Bill. consume more Unit", unitConsumed);
            }
            else
            {
                Console.WriteLine("Amount charges @ Rs{0} per unit: {1}", perUnitCharge, billCharged);
            }
            
            Console.WriteLine();


            // QUESTION NUMBER THREE

            // Console.WriteLine("Check for EVEN or ODD Number");
            // Console.Write("input the Number: ");
            // int number = int.Parse(Console.ReadLine());
            // var checkNumber = (number % 2 == 0) ? (number + " is an Even Number") : (number + " is an Odd Number");
            // Console.WriteLine(checkNumber);


            //  QUESTION NUMBER FOUR

            // int dayNumber = int.Parse(Console.ReadLine());
            // switch (dayNumber)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //     break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //     break;
            //     case 3:
            //         Console.WriteLine("Wednesday");
            //     break;
            //     case 4:
            //         Console.WriteLine("Thursday");
            //     break;
            //     case 5:
            //         Console.WriteLine("Friday");
            //     break;
            //     case 6:
            //         Console.WriteLine("Saturday");
            //     break;
            //     case 7:
            //         Console.WriteLine("Sunday");
            //     break;
            //     default:
            //         Console.WriteLine("NOT AMONG");
            //     break;
            // }

        }
    }
}
