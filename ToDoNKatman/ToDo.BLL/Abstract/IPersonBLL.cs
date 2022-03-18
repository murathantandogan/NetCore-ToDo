using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.Model.Entities;
using ToDo.ViewModel.PeopleViewModels;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.BLL.Abstract
{
    public interface IPersonBLL : IBaseBLL<Person>
    {

        ResultService<PeopleCreateVM> Insert(PeopleCreateVM user);
        ResultService<List<PeopleTotalVM>> GetPeopleAll();
        ResultService<PeopleTotalVM> Edit(int? id);
        ResultService<bool> EditSave(PeopleTotalVM people);
        ResultService<PeopleScoreVM> GetToDoScore();
    }



}
