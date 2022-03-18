using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.BLL.Abstract;
using ToDo.Model.Entities;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.DAL.Abstract;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.BLL.Concrete
{
    class ToDoItemService : IToDoItemBLL
    {
        IToDoItemDAL toDoItemRepository;

        public ToDoItemService(IToDoItemDAL toDoItemRepository)
        {
            this.toDoItemRepository = toDoItemRepository;
        }

        public ResultService<ToDoItemCreateVM> Create(ToDoItemCreateVM toDoItem)
        {
            ResultService<ToDoItemCreateVM> toDoItemResult = new ResultService<ToDoItemCreateVM>();

            try
            {
                ToDoItem addToDoItem = toDoItemRepository.Add(

                       new ToDoItem
                       {
                           Subject = toDoItem.Subject,
                           StartDate = toDoItem.StartDate,
                           EndDate = toDoItem.StartDate.AddDays(7),
                           Status = (Model.Enums.ItemStatu)toDoItem.Status,
                           Notes = toDoItem.Notes,
                           PersonID = Convert.ToInt32(toDoItem.PersonID)
                       });

                if (addToDoItem == null)
                {
                    throw new Exception("ekleme başarılı değil");
                }

                toDoItemResult.Data = toDoItem;

            }
            catch (Exception ex)
            {
                toDoItemResult.AddError("Exception", ex.Message);
            }

            return toDoItemResult;
        }


        public ResultService<List<ToDoItemTotalVm>> GetToDoAll()
        {
            ResultService<List<ToDoItemTotalVm>> resultService = new ResultService<List<ToDoItemTotalVm>>();

            try
            {
                List<ToDoItemTotalVm> toDoItemAll = toDoItemRepository.GetAll(a => a.IsActive, a => a.Person)
                        .OrderByDescending(a => a.StartDate)
                        .Select(toDoItem => new ToDoItemTotalVm
                        {
                            ID = toDoItem.ID,
                            Subject = toDoItem.Subject,
                            Status = (ViewModel.Enums.StatusEnum)toDoItem.Status,
                            StartDate = toDoItem.StartDate,
                            EndDate = toDoItem.EndDate,
                            PersonName = toDoItem.Person.Name

                        }).ToList();


                resultService.Data = toDoItemAll;

            }
            catch (Exception ex)
            {
                resultService.AddError("exception", ex.Message);
            }

            return resultService;
        }

        public ResultService<ToDoItemEditVM> Edit(int? id)
        {
            ResultService<ToDoItemEditVM> personResult = new ResultService<ToDoItemEditVM>();


            try
            {
                ToDoItem editToDo = toDoItemRepository.Get(a => a.ID == id, a => a.Person);

                var data = new ToDoItemEditVM
                {
                    ID = editToDo.ID,
                    Subject = editToDo.Subject,
                    StartDate = editToDo.StartDate.Date,
                    EndDate = editToDo.EndDate.Date,
                    Notes = editToDo.Notes,
                    Status = (ViewModel.Enums.StatusEnum)editToDo.Status,
                    PersonID = editToDo.Person.ID,
                    PersonName = editToDo.Person.Name


                };
                personResult.Data = data;

            }
            catch (Exception ex)
            {
                personResult.AddError("Exception", ex.Message);
            }




            return personResult;
        }

        public ResultService<bool> EditSave(ToDoItemEditVM toDoItem)
        {
            ResultService<bool> toDoResult = new ResultService<bool>();

            try
            {
                ToDoItem doItem = toDoItemRepository.Get(a => a.ID == toDoItem.ID);
                if (doItem == null)
                {
                    toDoResult.AddError("null hatası", "Bu guide sahip user yok");
                    return toDoResult;
                }

                doItem.Status = (Model.Enums.ItemStatu)toDoItem.Status;
                doItem.StartDate = toDoItem.StartDate.Date;
                doItem.EndDate = toDoItem.EndDate.Date;
                doItem.PersonID = toDoItem.PersonID;
                doItem.Subject = toDoItem.Subject;
                doItem.Notes = toDoItem.Notes;


                ToDoItem updateToDoItem = toDoItemRepository.Update(doItem);

                if (updateToDoItem == null)
                {
                    toDoResult.AddError("update hatası", "Update başarılı değil");
                    return toDoResult;
                }

                toDoResult.Data = true;

                return toDoResult;

            }
            catch (Exception ex)
            {
                toDoResult.AddError("Exception", ex.Message);
                return toDoResult;
            }


        }


        public ResultService<List<ToDoItemScoreVM>> GetToDoScore()
        {
            ResultService<List<ToDoItemScoreVM>> resultService = new ResultService<List<ToDoItemScoreVM>>();

            try
            {
                int resultToDo = toDoItemRepository.GetAll(a => a.Status == Model.Enums.ItemStatu.ToDo && a.IsActive).Count();
                int resultDoing = toDoItemRepository.GetAll(a => a.Status == Model.Enums.ItemStatu.Doing && a.IsActive).Count();
                int resultDone = toDoItemRepository.GetAll(a => a.Status == Model.Enums.ItemStatu.DOne && a.IsActive).Count();

                var ToDoToalVM = new List<ToDoItemScoreVM>()
                    {
                       new ToDoItemScoreVM(){
                           ToDoTotal=resultToDo,
                           DoingToTal=resultDoing,
                           DoneToTal=resultDone,
                       }
                    };
                resultService.Data = ToDoToalVM;
            }
            catch (Exception ex)
            {

                resultService.AddError("exception", ex.Message);
            }


            return resultService;
        }





    }
}

