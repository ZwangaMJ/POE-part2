using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace POEpart1._1
{
    delegate void DelegateHandler();
    class derivedExpenses : abstractExpenses
    {
        //Second class that reference the expense class
        public override double GrossIncome

        {
            get
            { return grossIncome; }
            set
            { grossIncome = value; }

        }


        public override double Tax
        {
            get
            { return tax; }
            set
            { //storing the tax into a percentage
                tax = (value / grossIncome) * 100; }

        }


        public override double rentAmount
        {
            get
            { return RentAmount; } set { RentAmount = value; } }


        public override double totalDeposit
        {
            get
            { return TotalDeposit; }
            set
            { TotalDeposit = value; }

        }


        public override double interestRate
        {
            get
            { return InterestRate; }
            set
            { InterestRate = value; }

        }


        public override double monthlyRepay
        {
            get
            { return MonthlyRepay; }
            set
            { MonthlyRepay = value; }

        }
        public override double purchasePrice
        {
            get
            { return PurchasePrice; }
            set
            { PurchasePrice = value; }

        }

        public override string make
        {
            get { return Make; }

            set { Make = value; } 
        }
        public override string model {
            get { return Model; } 
            set { Model = value; }
        }
        public override double carPurchasePrice { 
            get { return CarPurchasePrice; } 
            set { CarPurchasePrice = value; } 
        }
        public override double carTotalDeposit { 
            get { return CarTotalDeposit; } 
            set {CarTotalDeposit=value; } }
        public override double carInterestRate { 
            get {return CarInterestRate; } 
            set { CarInterestRate = value; } }
        public override double premium { 
            get { return Premium; } 
            set { Premium = value; } }

        //Method to calculate the home loan repayments
        public override double HomeloanCalculation()
        {
            purchasePrice = purchasePrice - totalDeposit;
            interestRate = interestRate / 100; //converting interest rate into percentage
            monthlyRepay = monthlyRepay / 12;
            double A;
            A = purchasePrice * (1 + interestRate * 2);
            double repayments;
            repayments = A / monthlyRepay;
            return repayments;
        }

        //method to calculate the rent
        public override double rental()
        {
            rentAmount = grossIncome - rentAmount;
            return rentAmount;
        }

      
        //method to prompt for rent values
        public void acceptRentValue() {
            try
            {
                //Prompting the user to enter the rental amount
                Console.WriteLine("Bot: Enter the Monthly rental amount: ");
                Console.Write("You: ");
                rentAmount = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bot: Your available monthly money after rent is deducted: " + rental());
            }
            catch (Exception) {
                Console.WriteLine("Invalid input");
            }
        }
        public void acceptHomeLoanValues() {
            try
            {
                //prompting the user to input purchase price
                Console.WriteLine("Bot: Enter the purchase price: ");
                Console.Write("You: ");
                purchasePrice = Double.Parse(Console.ReadLine());

                //Prompting the user to input the Deposit
                Console.WriteLine("Bot: Enter the total Deposit to pay: ");
                Console.Write("You: ");
                totalDeposit = Double.Parse(Console.ReadLine());

                //Prompting the user to input the interest rate
                Console.WriteLine("Bot: Enter the interest rate in percentage: ");
                Console.Write("You: ");
                interestRate = Double.Parse(Console.ReadLine());

                //prompting the user to input the Number of months 
                Console.WriteLine("Enter the number of month between 240 and 360: ");
                Console.Write("You: ");
                monthlyRepay = Double.Parse(Console.ReadLine());
            }
            catch (Exception) {
                Console.WriteLine("Invalid input");
            }
            double thirdOfGross; 
            thirdOfGross = grossIncome / 3;

            double leftover;
            leftover = grossIncome - HomeloanCalculation();
            //If statements to alert the user
            if (HomeloanCalculation() > thirdOfGross)
            {
                Console.WriteLine("Alert: Approval for Loan is unlikely sorry");
            }
            else
                if (HomeloanCalculation() < thirdOfGross)
            {
                Console.WriteLine("Alert: Your loan will be approved");
            }
            //Outputing the final remaining balance to the user 
            Console.WriteLine("Bot: Your available monthly money loan installment deductions: " + leftover);
        }
      
        //method to calculate vehicle purchase
        public override double CarPurchaseCalculations()
        {
            double vehiclePurchase = 0;
            carInterestRate = carInterestRate / 100; //converting car interest rate to percentage
            vehiclePurchase = (carPurchasePrice * (1 + carInterestRate * 5));
            vehiclePurchase = vehiclePurchase + premium;
            return vehiclePurchase; //returning the calculated value
        }

        public void carValues() {
            try
            {
                //prompting the user to input the Model
                Console.WriteLine("Bot: Enter the Model: ");
                Console.Write("You: ");
                model = Console.ReadLine();

                //prompting the user to input the car Maker
                Console.WriteLine("Bot: Enter the car maker: ");
                Console.Write("You: ");
                make = Console.ReadLine();

                //prompting the user to input purchase price
                Console.WriteLine("Bot: Enter the car purchase price: ");
                Console.Write("You: ");
                carPurchasePrice = Double.Parse(Console.ReadLine());

                //Prompting the user to input the Deposit
                Console.WriteLine("Bot: Enter the total Deposit to pay: ");
                Console.Write("You: ");
                carTotalDeposit = Double.Parse(Console.ReadLine());

                //Prompting the user to input the interest rate
                Console.WriteLine("Bot: Enter the interest rate in percentage: ");
                Console.Write("You: ");
                carInterestRate = Double.Parse(Console.ReadLine());

                //prompting the user to input the estimated insuarance premium 
                Console.WriteLine("Enter the estimated insuarance premium: ");
                Console.Write("You: ");
                premium = Double.Parse(Console.ReadLine());

                double remaining;
                remaining = grossIncome - CarPurchaseCalculations();

                Console.WriteLine("Bot: Your available monthly money after car purchase deductions: " + remaining);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!!!!");
            }

        }
        //Method to calculate 75% of the gross income
        public double netIncomePercentage() {
            double percentage;
            percentage = 75 / 100 * grossIncome; 

            return percentage;
        }
       
        //Method to alert the user
        public void alert1()
        {
                Console.WriteLine("Bot: Your expenses have exceeded 75% of your income!!!!");
            }
        //Second method to alert the user
        public void alert2() {
            Console.WriteLine("Bot: your expenses did not exceed 75% of your income!!!!");        
        }

        }

    }


    

