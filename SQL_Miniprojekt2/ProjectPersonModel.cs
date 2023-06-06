using System;
namespace SQL_Miniprojekt2
{
    public class ProjectPersonModel
    {
        public ProjectPersonModel()
        {
        }

        public int projectId { get; set; }

        public string projectName { get; set; }

        public int personId { get; set; }

        public string personName { get; set; }

        public int hours { get; set; }
        
    }
}

