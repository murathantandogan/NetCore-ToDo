using System;
using ToDo.Model.Enums;
using ToDO.Core.Entity;

namespace ToDo.Model.Entities
{
    public class ToDoItem : BaseEntity
    {

      
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public ItemStatu Status { get; set; }
        public int PersonID { get; set; }

        public Person Person { get; set; }

    }
}
