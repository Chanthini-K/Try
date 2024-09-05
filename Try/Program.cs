using System;
using System.Transactions;
class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("****File Changes***");
        Console.WriteLine("Enter a int value");
        int val_int = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a long value");
        long val_long = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter a float value");
        float val_float = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter a double value");
        Double val_double = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a char value");
        char val_char = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter a boolean value");
        bool val_bool = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter a String value");
        String val_string = Console.ReadLine();
        Console.WriteLine("Enter a String value");
        String vals_string = Console.ReadLine();
        //Arithmetic Operator
        //Arithmetic Operator
        //adding double and float
        Console.WriteLine("Adding double and float : " + (val_float + val_double));

        //subtracting int and long
        Console.WriteLine($"Subtracting long and int : {val_long - val_int}");

        //concatenation of string and char
        Console.WriteLine($"Concatenating String and char : {val_string + val_char}");    //-,*,% not possible

        //concatenation of Char and Char
        Console.WriteLine($"Concatenating char and char : {val_char + val_char}");//ASCII value  //-,*,% possible

        //concatenation of string and float
        Console.WriteLine($"Concatenating String and float : {val_string + val_float}");

        //concatenation of string, float and int 
        Console.WriteLine($"Concatenating String , float and int : {val_string + val_float + val_int}");

        //concatenation of float, int and String
        Console.WriteLine($"Concatenating  float , int and String : {val_float + val_int + val_string}");

        ////Logical Operators
        //Console.WriteLine("Enter a boolean value");
        //bool val_bool1 = Convert.ToBoolean(Console.ReadLine());
        //Console.WriteLine($"AND operator : {val_bool && val_bool1}");
        //Console.WriteLine($"OR operator : {val_bool || val_bool1}");
        //Console.WriteLine($"NOT operator : {!val_bool1}");
        //Console.WriteLine("==========================================");

        ////Relational Operator
        //Console.WriteLine("RELATIONAL OPERATORS");
        //bool res1 = 5 == 4;
        //bool res2 = 5 > 3;
        //bool res3 = "Idli" == "Idli";
        //bool res4 = "IDLI" == " idli";
        //bool res5 = 5 != 0;
        //bool res6 = false == false;
        //bool res7 = false == true;
        //bool res8 = true == true;
        //Console.WriteLine(res1);//false
        //Console.WriteLine(res2);//true
        //Console.WriteLine(res3);//true
        //Console.WriteLine(res4);//false
        //Console.WriteLine('A' == 65);//true
        //Console.WriteLine(res2 == res1);//false
        //Console.WriteLine(res5 == res5);//false
        //Console.WriteLine(res6 != res8);//false
        //Console.WriteLine("==========================================");

        ////Logical Operators
        //Console.WriteLine("LOGICAL OPERATORS");
        //int a = 10, b = 20, c = -30;
        //bool res1 = a == b && b == c;
        //Console.WriteLine(res1);
        //bool res2 = (res1 || false) && res1;
        //Console.WriteLine(res2);

        //Console.WriteLine("==========================================");
        ////Conditional Operator
        //Console.WriteLine("CONDITIONAL OPERATORS");
        //int res1 = (false) ? 4 : 48;
        //Console.WriteLine(res1);
        //double res2 = (5 > 3) ? 3.14 : 4.36;
        //Console.WriteLine(res2);
        //Console.WriteLine("==========================================");

        ////SizeOf Operator
        //Console.WriteLine("sizeof Operator");
        //int sizeOfInt = sizeof(int);
        //int sizeOfChar = sizeof(char);
        //int sizeOfDouble = sizeof(double);
        //Console.WriteLine("Size of Int: " + sizeOfInt);
        //Console.WriteLine("Size of Char: " + sizeOfChar);
        //Console.WriteLine("Size of Double: " + sizeOfDouble);

        //Console.WriteLine("==========================================");
        //Default Operator
        //Console.WriteLine("Default Operator");
        //int defaultInt = default(int);
        //long defaultLong = default(long);
        //float defaultFloat = default(float);
        //double defaultDouble = default(double);
        //bool defaultBool = default(bool);
        //Console.WriteLine("Default Value of int: " + defaultInt);
        //Console.WriteLine("Default Value of long: " + defaultLong);
        //Console.WriteLine("Default Value of float: " + defaultFloat);
        //Console.WriteLine("Default Value of double: " + defaultDouble);
        //Console.WriteLine("Default Value of bool: " + defaultBool);
        //Console.WriteLine("==========================================");


        //Console.WriteLine("Conditional Statements");

        /////if
        //Console.WriteLine("If Statement");
        //Console.WriteLine("Enter the boolean  value: ");
        //bool val1 = Convert.ToBoolean(Console.ReadLine());
        //if (val1)
        //    Console.WriteLine("This is if statement");

        //Console.WriteLine("==========================================");

        ////if-else 
        //Console.WriteLine("If-else Statement");
        //Console.WriteLine("Enter the 1st value: ");
        //int val2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the 2nd value: ");
        //int val3 = Convert.ToInt32(Console.ReadLine());
        //if (val2 > val3)
        //{
        //    Console.WriteLine($"{val2} is greater than {val3}");
        //}
        //else
        //{
        //    Console.WriteLine($"{val3} is greater than {val2}");

        //}

        //Console.WriteLine("==========================================");



        ////else-if
        //Console.WriteLine("else-if  Statement");
        //Console.WriteLine("Guess the number ");
        //Console.WriteLine("Enter your Guess: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //if (age < 50)
        //{
        //    Console.WriteLine("The number is greater than your guess");

        //}
        //else if (age == 50)
        //{
        //    Console.WriteLine("You guessed the number");

        //}
        //else
        //    Console.WriteLine("The number is lesser than your guess");

        //Console.WriteLine("==========================================");

        ////SWITCH
        //Console.WriteLine("Switch Statements");
        //Console.WriteLine("Enter a number to find a day");
        //int day = Convert.ToInt32(Console.ReadLine());
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Saturday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sunday");
        //        break;
        //    default:
        //        Console.WriteLine("There are only 7 days in a week");
        //        break;
        //}

        //Console.WriteLine("==========================================");
        //Console.WriteLine("Looping Statements");
        //Console.WriteLine("While Loop");
        //Console.WriteLine("Enter any number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Loop startss");
        //while (num < 5)
        //{
        //    ;
        //    Console.WriteLine(num);
        //    num++;
        //}

        //Console.WriteLine("==========================================");
        //Console.WriteLine("do-While Loop");
        //String input;
        //do
        //{
        //    Console.WriteLine("Type exit to quit the loop");
        //    input = Console.ReadLine();
        //    Console.WriteLine("You entered : " + input);
        //} while (input != "exit");

        //Console.WriteLine("==========================================");
        //Console.WriteLine("for Loop");
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine($"{i} Squared is {i * i}");
        //}
        //Console.WriteLine("==========================================");
        //Console.WriteLine("break-Statememt");
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 4)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);


        //}


        //Console.WriteLine("==========================================");
        //Console.WriteLine("Continue-Statememt");
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 4)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //Console.WriteLine("==========================================");
        //Console.WriteLine("for-each loop");
        //String[] fruits = { "Apple", "Orange", "Cherry", "Date" };
        //foreach (String fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}

        ////ARRAY
        //int[] a = new int[4];
        //Console.WriteLine("Oth index" + a[0]);
        //Console.WriteLine("1st index" + a[1]);
        //Console.WriteLine("2nd index" + a[2]);
        //Console.WriteLine("3rd index" + a[3]);
        //Console.WriteLine("********After Assigning values***********");
        //a[0] = 20;
        //a[1] = 30;
        //a[2] = 40;
        //a[3] = 50;
        //Console.WriteLine("Oth index" + a[0]);
        //Console.WriteLine("1st index" + a[1]);
        //Console.WriteLine("2nd index" + a[2]);
        //Console.WriteLine("3rd index" + a[3]);

        //STATIC WAY OF ARRAY CREATION
        //Console.WriteLine("Static Way of Array Creation");
        //String[] s = { "SQL", "Java", "C#" };
        //Console.WriteLine("The length is: " + s.Length);
        //for (int i = 0; i < s.Length; i++)
        //{
        //    Console.WriteLine("The array elements are : " + s[i]);
        //}


    }
}
