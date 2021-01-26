using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeViewS
{
    public class Project
    {
        public string Name { get; set; }
        public Types types { get; set; }
        public Instances instances { get; set; }
    }


    public class Types
    {
        public string Name { get; set; }
        public List<ProjectType> projectType { get; set; }
    }

    public class ProjectType
    {
        public string Name { get; set; }
    }

    public class Instances
    {
        public string Name { get; set; }
        public List<ProjectInstance> projectInstance { get; set; }
    }

    public class ProjectInstance
    {
        public string Name { get; set; }
    }

}
