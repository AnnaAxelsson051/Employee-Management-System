using System;
using Dapper;
using Npgsql;
using System.Configuration;
using System.Data;

namespace SQL_Miniprojekt2
{
    public class DatabaseAccess
    {


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //Adds new person to db

        public static void AddNewPersonToDb(string personName)
        {

            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {

                //cnn.Execute
                var output = cnn.Query($"INSERT INTO aax_person (person_name) VALUES ('{personName}')",
                    new DynamicParameters());
                return;
            }
        }

        //Adds new project to db

        public static void AddNewProjectToDb(string projectName)
        {

            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {

                //cnn.Execute
                var output = cnn.Query($"INSERT INTO aax_project (project_name) VALUES '{projectName}'",
                    new DynamicParameters());
                return;
            }
        }

        //Registers workhours on a specified project and person

        public static void RegisterWorkHoursInDb(string personName, string projectName, int hours)
        {

            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {

                //cnn.Execute("INSERT INTO person_project (name, project_name, hours) values (@name, @project, @work_hours)");
                var output = cnn.Query($"INSERT INTO aax_project_person (person_name, project_name, hours) " +
                    $"VALUES ('{personName}', '{projectName}', {hours})", new DynamicParameters());
                return;
            }
        }


        
    }
}

