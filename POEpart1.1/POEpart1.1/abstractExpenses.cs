using System;
using System.Collections.Generic;
using System.Text;

namespace POEpart1._1
{
    //Abstract class that stores expenses 
    abstract class abstractExpenses
    {
        protected double grossIncome;

        public abstract double GrossIncome {
            get;
            set;
        }

        protected double tax;

        public abstract double Tax
        {
            get;
            set;
        }

        protected double RentAmount;

        public abstract double rentAmount
        {
            get;
            set;
        }

        protected double PurchasePrice;

        public abstract double purchasePrice
        {
            get;
            set;
        }

        protected double TotalDeposit;

        public abstract double totalDeposit
        {
            get;
            set;
        }

        protected double InterestRate;

        public abstract double interestRate
        {
            get;
            set;
        }
        protected double MonthlyRepay;

        public abstract double monthlyRepay
        {
            get;
            set;
        }
        protected string Make;
        public abstract string make
         {
            get;
            set;
         }
        protected string Model;
        public abstract string model
        {
            get;
            set;
        }
        protected double CarPurchasePrice;
        public abstract double carPurchasePrice
        {
            get;
            set;
        }
        protected double CarTotalDeposit;
        public abstract double carTotalDeposit
        {
            get;
            set;
        }

        protected double CarInterestRate;
        public abstract double carInterestRate
        {
            get;
            set;
        }

        protected double Premium;
        public abstract double premium
        {
            get;
            set;
        }

        public abstract  double HomeloanCalculation();
        public abstract double rental();

        public abstract double CarPurchaseCalculations();
    }
}
