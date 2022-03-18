

using ToDo.DAL.Abstract;
using ToDo.DAL.Concrete.Context;
using ToDo.Model.Entities;
using ToDO.Core.DataAccess.EntityFramework;

namespace ToDo.DAL.Concrete.Repository
{
    class PersonPepository : EFRepositoryBase<Person, ToDoDbContext>, IPersonDAL
    {

        public PersonPepository(ToDoDbContext context) : base(context)
        {

        }


    }
}
