using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DAL.Abstract;
using ToDo.DAL.Concrete.Context;
using ToDo.DAL.Concrete.Repository;

namespace ToDo.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {

            services.AddDbContext<ToDoDbContext>();
            services.AddScoped<IPersonDAL, PersonPepository>();
            services.AddScoped<IToDoItemDAL, ToDoItemPepository>();
           
        }




    }
}
