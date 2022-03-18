using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.Abstract;
using ToDo.DAL.Concrete.DependencyInjection;

namespace ToDo.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {

        public static void AddScopeBLL (this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IPersonBLL, PersonService>();
            services.AddScoped<IToDoItemBLL, ToDoItemService>();

        }


    }
}
