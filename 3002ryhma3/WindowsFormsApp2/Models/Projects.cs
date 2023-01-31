using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{

    public class Projects
    {
        public int ProjectID { get; set; }
        public string Project_name { get; set; }
        public int FK_TeamID { get; set; }
    }
}
