using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model.Entities;
using ToDO.Core.DataAccess;

namespace ToDo.DAL.Abstract
{
   public interface IToDoItemDAL : IRepository<ToDoItem>
    {
    }
}
