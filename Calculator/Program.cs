using System;

namespace Calculator
{
    class Program
    {
        string entered;
        bool used;
        double tempnum1, tempnum2, carriednum;
        BMI b = new BMI();

        public static void Main()
        {
            //Creating the objects of the classes
            Program c = new Program();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============\n  Calculator \n============== ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please select what calculation you would like to do." +
                "\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.BMI Calculator");
            c.switchStatement();
            Console.WriteLine(c.used);
        }
        void switchStatement()
        {
            entered = Console.ReadLine();
            switch (entered)
            {
                case "1":
                    Input();
                    Add();
                    Loop();
                    break;
                case "2":
                    Input();
                    Subtract();
                    Loop();
                    break;
                case "3":
                    Input();
                    Multiply();
                    Loop();
                    break;
                case "4":
                    Input();
                    Divide();
                    Loop();
                    break;
                case "5":
                    b.Bmi();
                    break;
                default:
                    Console.WriteLine("Unexpected value, try again:  " + entered);
                    switchStatement();
                    break;
            }
        }
        void Input()
        {
            string word = "empty";
            if (entered == "1"){word = "Addition";}
            else if (entered == "2"){word = "Subtraction";}
            else if (entered == "3") { word = "Multiplication"; }
            else if (entered == "4") { word = "Division"; }
            if (used == false)
            {
                Console.WriteLine("Method:" + word + "\nPlease enter the first value.");
                tempnum1 = Convert.ToDouble(Console.ReadLine());
            }
            if (used == true) { Console.WriteLine("Method: " + word); }
            Console.WriteLine("Please enter the second value.");
            tempnum2 = Convert.ToDouble(Console.ReadLine());
        }
        void Add()
        {
            Console.Read();
            double funAdd(double one, double two)
            {
                return one + two;
            }
            if (used == false) { Console.WriteLine("===========\nResult: " + funAdd(tempnum1, tempnum2) + "\n==========="); carriednum = funAdd(tempnum1, tempnum2); }
            else if (used == true) { Console.WriteLine("===========\nResult: " + funAdd(carriednum, tempnum2) + "\n==========="); carriednum = funAdd(carriednum, tempnum2); }
        }
        void Subtract()
        {
            double funSub(double one, double two)
            {
                return one - two;
            }
            if (used == false) { Console.WriteLine("===========\nResult: " + funSub(tempnum1, tempnum2) + "\n==========="); carriednum = funSub(tempnum1, tempnum2); }
            else if (used == true) { Console.WriteLine("===========\nResult: " + funSub(carriednum, tempnum2) + "\n==========="); carriednum = funSub(carriednum, tempnum2); }
        }
        void Multiply()
        {
            double funMultiply(double one, double two)
            {
                return one * two;
            }
            if (used == false) { Console.WriteLine("===========\nResult: " + funMultiply(tempnum1, tempnum2) + "\n==========="); carriednum = funMultiply(tempnum1, tempnum2); }
            else if (used == true) { Console.WriteLine("===========\nResult: " + funMultiply(carriednum, tempnum2) + "\n==========="); carriednum = funMultiply(carriednum, tempnum2); }
        }
        void Divide()
        {
            double funDivide(double one, double two)
            {
                if (two == 0)
                {
                    return one / (1 - two);
                }
                return one / two;
            }
            if (used == false) { Console.WriteLine("===========\nResult: " + funDivide(tempnum1, tempnum2) + "\n==========="); carriednum = funDivide(tempnum1, tempnum2); }
            else if (used == true) { Console.WriteLine("===========\nResult: " + funDivide(carriednum, tempnum2) + "\n==========="); carriednum = funDivide(carriednum, tempnum2); }
        }
        void Loop()
        {
            Console.WriteLine("\nDo you want to continue with your resulting number?\n1.Yes\n1.No");
            string typed = Console.ReadLine();
            switch (typed)
            {
                case "1":
                case "yes":
                    used = true; Console.WriteLine("Please select the operator");
                    switchStatement();
                    break;
                case "no":
                case "2":
                    Console.Clear();
                    Main();
                    break;
            }
        }
    }

    class BMI
    {
        public void Bmi()
        {
            double height;
            int weight;
            string gender, bmiStatus = "Empty", entered;
            Console.Clear();
            Console.WriteLine("===========================\n     BMI Calculator\n===========================");
            Console.WriteLine("Please enter your gender\n1.Male\n2.Female");
            gender = Console.ReadLine();
            Console.WriteLine("Please enter your weight in kg");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height in centimeters");
            height = Convert.ToDouble(Console.ReadLine());
            double BMI = weight / Math.Pow(height / 100.0, 2); //Using Math. to enable me to use powers
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
            entered = Console.ReadLine();
            if (entered == "1") Bmi();
            else if (entered == "2") Console.Clear(); Program.Main();
        }
    }
}
