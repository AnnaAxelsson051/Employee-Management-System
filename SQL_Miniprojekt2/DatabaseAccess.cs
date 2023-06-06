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
                var query = cnn.Query($"INSERT INTO aax_person (person_name) VALUES ('{personName}')",
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
                var output = cnn.Query($"INSERT INTO aax_project (project_name) VALUES ('{projectName}')",
                    new DynamicParameters());
                return;
            }
        }

        //Registers workhours on a specified project and person

        public static void RegisterWorkHoursInDb(string personName, string projectName, int hours)
        {

            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {

                ////cnn.Execute("INSERT INTO person_project (name, project_name, hours) values (@name, @project, @work_hours)");
                var output = cnn.Query($"INSERT INTO aax_project_person (person_name, project_name, hours) " +
                    $"VALUES ('{personName}', '{projectName}', {hours})", new DynamicParameters());
                return;
            }
        }

        //Modify specific person

        public static void ModifyPersonInDb(string oldPersonName, string newPersonName)
        {
            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query($"UPDATE aax_person SET person_name = ('{newPersonName}') " +
                    $"WHERE person_name = ('{oldPersonName}')", new DynamicParameters());
                return;
            }
        }

        //Modify specific project/

        public static void ModifyProjectInDb(string oldProjectName, string newProjectName)
        {
            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query($"UPDATE aax_project SET project_name = ('{newProjectName}') " +
                    $"WHERE project_name = ('{oldProjectName}')", new DynamicParameters());
                return;
            }
        }
        //Modify working hours on specific project/

        public static void ModifyWorkHoursInDb(string personName, string projectName, int hours)
        {
            using (IDbConnection cnn = new NpgsqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query($"UPDATE aax_project_person SET hours = ('{hours}') " +
                    $"WHERE person_name = ('{personName}') AND project_name = ('{projectName}')", new DynamicParameters());
                return;
            }
        }


    }
}

