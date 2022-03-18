using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DAL.Abstract;
using ToDo.DAL.Concrete.Context;
using ToDo.Model.Entities;
using ToDO.Core.DataAccess.EntityFramework;

namespace ToDo.DAL.Concrete.Repository
{
     class ToDoItemPepository : EFRepositoryBase<ToDoItem, ToDoDbContext>, IToDoItemDAL
    {


        public ToDoItemPepository(ToDoDbContext context) : base(context)
        {

        }
    }
}
