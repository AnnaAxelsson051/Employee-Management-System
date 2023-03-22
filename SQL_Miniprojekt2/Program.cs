namespace SQL_Miniprojekt2;
class Program
{
    static void Main(string[] args)
    {
        MainMenu();

        void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("---------- [ Time Logger System Menu ] ----------");
            Console.WriteLine("");
            bool startMenu = true;
            while (startMenu)
            {
                Console.WriteLine("Welcome to the Time Logger system");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("");
                Console.WriteLine("1. Create a new person");
                Console.WriteLine("2. Create a new project");
                Console.WriteLine("3. Report work hours");
                Console.WriteLine("4. Modify person");
                Console.WriteLine("5. Modify project");
                Console.WriteLine("6. Modify work hours");
                Console.WriteLine("E. Exit");
                Console.WriteLine("");
                string? userOption = Console.ReadLine().ToUpper();
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Add a new person");
                        AddNewPerson();
                        //startMenu = false;
                        break;
                    case "2":
                        Console.WriteLine("Add a new project");
                        AddNewProject();
                        //startMenu = false;
                        break;
                    case "3":
                        Console.WriteLine("Report work hours");
                        RegisterWorkHours();
                        //startMenu = false;
                        break;
                    case "4":
                        Console.WriteLine("Modify person");
                        ModifyPerson();
                        //startMenu = false;
                        break;
                    case "5":
                        Console.WriteLine("Modify project");
                        ModifyProject();
                        //startMenu = false;
                        break;
                    case "6":
                        Console.WriteLine("Modify work hours");
                        ModifyWorkhours();
                        //startMenu = false;
                        break;

                    case "E":
                        Console.WriteLine("You have chosen to exit the application");
                        Console.WriteLine();
                        startMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please select one of the listed options");
                        Console.WriteLine();
                        break;

                }
            }
        }

    }