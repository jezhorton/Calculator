using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonMethodCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, answer, weight, height;                  //Variables for equation
            string operation, selection, gender, bmiStatus = "empty";
            Console.WriteLine("Hello, welcome to Jez's basic calculator!");
            Console.WriteLine("1.Calculator\n2.BMI calculation");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                Console.WriteLine("===========================\n     BMI Calculator\n===========================");
                Console.WriteLine("Please enter your gender\n1.Male\n2.Female");
                gender = Console.ReadLine();
                Console.WriteLine("Please enter your weight in kg");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your height in centimeters");
                height = Convert.ToInt32(Console.ReadLine());
                double BMI = weight / Math.Pow(height / 100.0, 2); //Not sure if I was allowed to use math. but it just saves me doing another height / 100
                if (gender == "1" | gender == "male")
                {
                    if (BMI < 18) bmiStatus = "Underweight";
                    else if (BMI >= 18 & BMI < 25) bmiStatus = "Normal";
                    else { bmiStatus = "Overweight"; }
                }
                else if (gender == "2" | gender == "female")
                {
                    if (BMI < 17) bmiStatus = "Underweight";
                    else if (BMI >= 17 & BMI < 24) bmiStatus = "Normal";
                    else { bmiStatus = "Overweight"; }
                }
                Console.WriteLine("BMI:  " + BMI + "\nStatus:  " + bmiStatus + "\n1. Enter another BMI\n2. Go back to the calculator");
            }
            else if (selection == "2")
            {
            Console.Write("Enter the first number in your basic equation: ");
            }
            firstNum = Convert.ToInt32(Console.ReadLine());
            //User input for equation
            Console.Write("Now enter your second number in the basic equation: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ok now enter your operation ( x , / , +, -) ");
            operation = Console.ReadLine();
            if (operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
            }
            //Getting answers
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
            }
            else
            {
                Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
            }
            Console.ReadKey();
        }
    }
}

