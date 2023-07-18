using System.ComponentModel.Design;
using System.Reflection.Emit;

int input = 0;
while (true)

    try
    {
        Console.WriteLine("WELCOME TO YOUR TO DO TASK PLANNING\n\nSelect a number to represent the task Day:\n\n1.MONDAY\t\t2.TUESDAY\n3.WEDNESSDAY\t\t4.THURSDAY\n5.FRIDAY\t\t6.SATURDAY\n7.SUNDAY");
    
    {
        input = Convert.ToInt32(Console.ReadLine());

        if (input == 6 || input == 7)
        {
            Console.WriteLine("No Task Allow for WeekDays");

        }

        switch (input)
        {
            case 1:
                InputMethods();
                break;
            case 2:
                InputMethods();
                break;
            case 3:
                    Console.WriteLine("Assessment Day");
                break;
            case 4:
                InputMethods();
                break;
            case 5:
                InputMethods();
                break;
            case 9:
                    continue;
                

            default:
                {
                    Console.WriteLine("Invalid selection");
                }
                break;
        }


        static void InputMethods()

        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Add Task");
                    string Event = Console.ReadLine();
                    Console.WriteLine("Add Time in 24hrs format e.g From 1 to 24 \nEnter Hour only");
                    Start: int Hour = Convert.ToInt32(Console.ReadLine());
                    if (Hour > 24 || Hour < 0)
                    {
                        Console.WriteLine("Invalid Hour Format Try Again");
                            goto Start;
                    }

                    Console.WriteLine("Enter Minutes");
                    Label: int Minutes = Convert.ToInt32(Console.ReadLine());
                    if (Minutes > 60 || Minutes < 0)
                    {
                        Console.WriteLine("Invalid Minutes Format Try again");
                         goto Label;
                    }
                    
                   else Console.WriteLine($"Your Task To {Event} by {Hour}:{Minutes} has been successfully added Press 0 to cancel or\nContinue");

                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
catch
{
    Console.WriteLine("You have entered an invalid selection");
}

  

