using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class Tasks
    {
            public int TaskID { get; set; }
            public string Task_name { get; set; }
            public string Description { get; set; }
            public int Status { get; set; }
            public int Estimated_Time { get; set; }
            public int Actual_Time { get; set; }
            public int Priority { get; set; }
            public int Difficulty { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int FK_StoryID { get; set; }
    }
}
