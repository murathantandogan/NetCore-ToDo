using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.ViewModel.Enums;

namespace ToDo.ViewModel.ToDoItemViewModels
{
    public class ToDoItemTotalVm
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }        
        public string PersonName { get; set; }



    }
}
