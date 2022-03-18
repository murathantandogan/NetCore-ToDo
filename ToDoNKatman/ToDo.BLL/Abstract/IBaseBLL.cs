using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDO.Core.Entity;

namespace ToDo.BLL.Abstract
{
    public interface IBaseBLL <TEntity>
        where TEntity:BaseEntity
    {
    }
}
