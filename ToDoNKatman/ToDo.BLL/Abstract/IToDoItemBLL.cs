using System.Collections.Generic;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.Model.Entities;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.BLL.Abstract
{
    public interface IToDoItemBLL : IBaseBLL<ToDoItem>
    {
        ResultService<ToDoItemCreateVM> Create(ToDoItemCreateVM toDoItem);
        ResultService<List<ToDoItemTotalVm>> GetToDoAll();
        ResultService<ToDoItemEditVM> Edit(int? id);
        ResultService<bool> EditSave(ToDoItemEditVM toDoItem);
        ResultService<List<ToDoItemScoreVM>> GetToDoScore();
    }
}
