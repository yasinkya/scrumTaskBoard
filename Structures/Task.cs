using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Structures
{
    class Task
    {
        public int TaskId { get; set; }
        public  string TaskName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string StartDate { get; set; }
        public string EstimatedDate { get; set; }
        public string FinishDate { get; set; }
        public string Importance { get; set; }
        public string UserName { get; set; }
        public string PanelName { get; set; }
        public string ProjectName { get; set; }

    }
}
