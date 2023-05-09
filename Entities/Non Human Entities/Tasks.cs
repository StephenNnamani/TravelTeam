using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Non_Human_Entities
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public int IdOfTheCreator { get; set; }
        public int IdOfTheExecutor { get; set; }
        public string? Task { get; set; }
        public string? TaskNote { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime DeadLineDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
