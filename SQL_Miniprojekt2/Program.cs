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

        static void AddNewPerson()
        {
            Console.WriteLine("Please type the name of the person you wold like to add");
            string? personName = Console.ReadLine();
            ///DatabaseAccess.AddNewPersonToDb(personName);
            Console.WriteLine("Person " + personName + " has been successfully added");


            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        static void AddNewProject()
        {
            Console.WriteLine("Please type the name of the project you would like to add");
            string? projectName = Console.ReadLine();
            //DatabaseAccess.AddNewProjectToDb(projectName);
            Console.WriteLine("Project" + projectName + " has been successfully added");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        static void RegisterWorkHours()
        {
            Console.WriteLine("Please type the name of the person you would like to add work hours to");
            string? personName = Console.ReadLine();
            Console.WriteLine("Please type the name of the project you would like to register");
            string? projectName = Console.ReadLine();
            Console.WriteLine("Please type the number of hours");
            string? input = Console.ReadLine();
            int hours = Convert.ToInt32(input);
            //DatabaseAccess.RegisterWorkHoursInDb(personName, projectName, hours);
            Console.WriteLine("Person " + personName + ", project " + projectName + " and " + hours
                + "h has been successfully added");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

       
    }
}



