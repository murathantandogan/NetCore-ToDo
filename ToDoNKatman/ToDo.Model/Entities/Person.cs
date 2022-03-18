using System.Collections.Generic;
using ToDO.Core.Entity;

namespace ToDo.Model.Entities
{
    public class Person : BaseEntity
    {
        public Person()
        {
            ToDoItems = new HashSet<ToDoItem>();
        }
               
        public string Name { get; set; }

        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
