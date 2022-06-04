using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
/*Zwanga Muthavhine
 * Varsity College Student
 * ST10085086
*/
namespace POEpart1._1
{

    class Program
    {

        static void Main(string[] args)
        {
            Program N = new Program();
            derivedExpenses D = new derivedExpenses();
          
          try
            {
                //Prompting the user to input gross income
                Console.WriteLine("Bot: Enter gross Income before deductions");
                Console.Write("You: ");
                D.GrossIncome = Double.Parse(Console.ReadLine());

                //prompting the user to input tax
                Console.WriteLine("Bot: Enter tax deduction: ");
                Console.Write("You: ");
                D.Tax = Double.Parse(Console.ReadLine());

                //Storing expenses into generic collection
                List<double> expenses = new List<double>(4);
                double varListInput = 0;
                Console.WriteLine("Bot: Enter your estimated monthly expenditures in groceries: ");
                Console.Write("You: ");
                varListInput = Double.Parse(Console.ReadLine());
                expenses.Add(varListInput);
                Console.WriteLine("Bot: Enter your estimated monthly expenditures in water and lights: ");
                Console.Write("You: ");
                varListInput = Double.Parse(Console.ReadLine());
                expenses.Add(varListInput);
                Console.WriteLine("Bot: Enter your estimated monthly expenditures in travel costs (including petrol): ");
                Console.Write("You: ");
                varListInput = Double.Parse(Console.ReadLine());
                expenses.Add(varListInput);
                Console.WriteLine("Bot: Enter your estimated monthly expenditures in cell phone and telephone: ");
                Console.Write("You: ");
                varListInput = Double.Parse(Console.ReadLine());
                expenses.Add(varListInput);
                Console.WriteLine("Bot: Enter your estimated monthly expenditures in other expenses: ");
                Console.Write("You: ");
                varListInput = Double.Parse(Console.ReadLine());
                expenses.Add(varListInput);


                double expenditureSum = expenses.Sum();//adding all expenses 

                //ORDER BY DESCENDING
                var result = expenses.OrderByDescending(a => ((float)a));
                Console.WriteLine("Bot: Your expenses in descending order: ");
                foreach (var item in result)
                {
                    //desplaying expenses in descending order
                    Console.WriteLine("Expenses: "+item);
                }

                //new grossIncome after expense deductions
                double newGross;
                newGross = D.GrossIncome - D.Tax - expenditureSum;

                //Outputing the remaining balance
                Console.WriteLine("Bot: the remaining balance after specified deduction is: " + newGross);

                //Prompting the user to choose between Home Loan, renting and Car Purchases
                int choice;
                Console.WriteLine("Bot: Do you want to Rent or Buy? \n Press: 1 for Renting \t Press: 2 for Home Loan \t Press: 3 for Car Purchase ");
                Console.Write("You: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    D.acceptRentValue(); //calling method to display rent option
                    DelegateHandler Dt = D.alert1; //Multicast Delegate
                    double Results;
                    Results = D.rental() + expenditureSum;
                    if (Results < D.netIncomePercentage())//Condition to output delegate alert
                    {
                        Dt = Dt + D.alert1;
                        D.alert1();
                    }
                    else { D.alert2(); }
                }
                else
                {
                    if (choice == 2)
                    {
                        D.acceptHomeLoanValues();//calling method to display home loan option
                        DelegateHandler Dt = D.alert1;//Multicast Delegate
                        double Results;
                        Results = D.HomeloanCalculation() + expenditureSum;
                        if (Results < D.netIncomePercentage())
                        {
                            Dt = Dt + D.alert1;
                            D.alert1();
                        }
                        else { D.alert2(); }
                    }

                    else
                    {
                        if (choice == 3)
                        {
                            D.carValues();//callijng method to display Car purchase option
                            DelegateHandler Dt = D.alert1;//multicast delegate
                            double Results;
                            Results = D.CarPurchaseCalculations() + expenditureSum;
                            if (Results < D.netIncomePercentage())
                            {
                                Dt = Dt + D.alert1;
                                D.alert1();
                            }
                            else { D.alert2(); }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!!!!!");
                return;
            }
        }
        }
    }

