using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class User_Stories
    {
        public int StoryID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public int FK_SprintID { get; set; }
    }
}
