int x;
int y;
string equation;
int sum;
bool isrunning = true;
string con;
string next;



while (isrunning)
{
    Console.WriteLine("What would you like to do?"); //ask user a question
    equation = Console.ReadLine()!; //takes user input
    equation = char.ToUpper(equation[0]) + equation.Substring(1).ToLower(); //makes the first letter of the word uppercase and the rest lower case

    switch (equation) //Depending on what equation is picked, programs tries to find the case with the specific equation
    {
        case "Add":
            Console.WriteLine("Give me a number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number");
            y = Convert.ToInt32(Console.ReadLine());
            sum = x + y;

            Console.WriteLine("The total is " + sum);

            Console.WriteLine("Would you like to add more numbers? Yes/No? ");
            next = Console.ReadLine()!;
            if (next == "Yes")
            {
                Console.WriteLine("Add another number. Enter 0 to stop");
                int z = Convert.ToInt32(Console.ReadLine()!);
                while (z != 0)
                {
                    sum += z;
                    Console.WriteLine(sum);
                    Console.WriteLine("Add another number");
                    z = Convert.ToInt32(Console.ReadLine());
                }
            }


            break;

        case "Subtract":
            Console.WriteLine("Give me a number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x - y;
            Console.WriteLine("The total is " + sum);

            Console.WriteLine("Would you like to subtract more numbers? Yes/No? ");
            next = Console.ReadLine()!;
            if (next == "Yes")
            {
                Console.WriteLine("Subtract another number. Enter 0 to stop");
                int z = Convert.ToInt32(Console.ReadLine());
                while (z != 0)
                {
                    sum -= z;
                    Console.WriteLine(sum);
                    Console.WriteLine("Subtract another number");
                    z = Convert.ToInt32(Console.ReadLine());
                }
            }

            break;

        case "Multiply":
            Console.WriteLine("Give me a number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x * y;
            Console.WriteLine("The total is " + sum);

            Console.WriteLine("Would you like to multiply more numbers? Yes/No? ");
            next = Console.ReadLine()!;
            if (next == "Yes")
            {
                Console.WriteLine("Multiply another number. Enter 0 to stop");
                int z = Convert.ToInt32(Console.ReadLine());
                while (z != 0)
                {
                    sum *= z;
                    Console.WriteLine(sum);
                    Console.WriteLine("Multiply another number");
                    z = Convert.ToInt32(Console.ReadLine());
                }
            }

            break;

        case "Divide":
            Console.WriteLine("Give me a number");
            x = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Give me another number");
            y = Convert.ToInt32(Console.ReadLine()!);
            while (y == 0)
            {
                Console.WriteLine("Can't divide by zero, enter a new number");
                y = Convert.ToInt32(Console.ReadLine()!);
            }

            sum = x / y;
            Console.WriteLine("The total is " + sum);

            Console.WriteLine("Would you like to divide more numbers? Yes/No? ");
            next = Console.ReadLine()!;
            if (next == "Yes")
            {
                Console.WriteLine("Divide another number. Enter 0 to stop");
                int z = Convert.ToInt32(Console.ReadLine());
                while (z != 0)
                {
                    sum /= z;
                    Console.WriteLine(sum);
                    Console.WriteLine("Divide another number");
                    z = Convert.ToInt32(Console.ReadLine());
                }
            }

            break;

        default:
            Console.WriteLine("Invalid equation");
            break;
    }

    Console.WriteLine("Continue? yes or no?");
    con = Console.ReadLine()!;
    con = con.ToLower();
    if (con == "no") 
    {
        isrunning = false;
    }
}

Console.WriteLine("Program terminated");



