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
                        AddNewPerson();
        
                        break;
                    case "2":                       
                        AddNewProject();
              
                        break;
                    case "3":
                        RegisterWorkHours();
                  
                        break;
                    case "4":
                        ModifyPerson();
                 
                        break;
                    case "5":
                        ModifyProject();
                    
                        break;
                    case "6":
                        ModifyWorkhours();
                   
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
            DatabaseAccess.AddNewPersonToDb(personName);
            Console.WriteLine("Person " + personName + " has been successfully added");


            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        static void AddNewProject()
        {
            Console.WriteLine("Please type the name of the project you would like to add");
            string? projectName = Console.ReadLine();
            DatabaseAccess.AddNewProjectToDb(projectName);
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
            DatabaseAccess.RegisterWorkHoursInDb(personName, projectName, hours);
            Console.WriteLine("Person " + personName + ", project " + projectName + " and " + hours
                + "h has been successfully added");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        //Replace name of person

        static void ModifyPerson()
        {
            Console.WriteLine("Please type the name of the person you would like to replace");
            string? oldPersonName = Console.ReadLine();
            Console.WriteLine("Please type the name of the person you would like to add instead of " + oldPersonName);
            string? newPersonName = Console.ReadLine();
            DatabaseAccess.ModifyPersonInDb(oldPersonName, newPersonName);
            Console.WriteLine("Person name " + oldPersonName + " has been successfully replaced with " + newPersonName);
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        //Replace name of project

        static void ModifyProject()
        {
            Console.WriteLine("Please type the name of the project you would like to replace");
            string? oldProjectName = Console.ReadLine();
            Console.WriteLine("Please type the name of the project you would like to add instead of " + oldProjectName);
            string? newProjectName = Console.ReadLine();
            DatabaseAccess.ModifyProjectInDb(oldProjectName, newProjectName);
            Console.WriteLine("Project name " + oldProjectName + " has been successfully replaced with " + newProjectName);
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }

        //Modify number of worked hours for specific person and project

        static void ModifyWorkhours()
        {
            Console.WriteLine("Please enter the name of the person whos work hours you would like to modify");
            string? personName = Console.ReadLine();
            Console.WriteLine("Please enter the name of the project");
            string? projectName = Console.ReadLine();
            Console.WriteLine("Please enter the new number of hours");
            string? input = Console.ReadLine();
            int hours = Convert.ToInt32(input);
            DatabaseAccess.ModifyWorkHoursInDb(personName, projectName, hours);
            Console.WriteLine("Work hours for " + personName + " on project " + projectName + " has been " +
                "successfully updated to " + hours + "h");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }
    }
}



