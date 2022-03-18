using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.BLL.Abstract;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.DAL.Abstract;
using ToDo.Model.Entities;
using ToDo.ViewModel.PeopleViewModels;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.BLL.Concrete
{
    class PersonService : IPersonBLL
    {

        IPersonDAL personRepository;

        public PersonService(IPersonDAL personRepository)
        {
            this.personRepository = personRepository;
        }


        public ResultService<List<PeopleTotalVM>> GetPeopleAll()
        {
            ResultService<List<PeopleTotalVM>> resultService = new ResultService<List<PeopleTotalVM>>();

            try
            {
                List<PeopleTotalVM> peopleAll = personRepository.GetAll()
                        .OrderBy(a => a.ID)
                        .Select(people => new PeopleTotalVM
                        {
                            ID = people.ID,
                            Name = people.Name,
                        }).ToList();
                resultService.Data = peopleAll;

            }
            catch (Exception ex)
            {
                resultService.AddError("exception", ex.Message);
            }

            return resultService;
        }


        public ResultService<PeopleCreateVM> Insert(PeopleCreateVM people)
        {
            ResultService<PeopleCreateVM> personResult = new ResultService<PeopleCreateVM>();

            try
            {
                Person addPerson = personRepository.Add(

                       new Person
                       {
                           Name = people.Name
                       });

                if (addPerson == null)
                {
                    throw new Exception("ekleme başarılı değil");
                }

                personResult.Data = people;

            }
            catch (Exception ex)
            {
                personResult.AddError("Exception", ex.Message);
            }

            return personResult;


        }



        public ResultService<PeopleTotalVM> Edit(int? id)
        {
            ResultService<PeopleTotalVM> personResult = new ResultService<PeopleTotalVM>();


            try
            {
                Person editPerson = personRepository.Get(a => a.ID == id);

                var data = new PeopleTotalVM
                {
                    ID = editPerson.ID,
                    Name = editPerson.Name,
                };
                personResult.Data = data;

            }
            catch (Exception ex)
            {
                personResult.AddError("Exception", ex.Message);
            }




            return personResult;
        }

        public ResultService<bool> EditSave(PeopleTotalVM people)
        {

            ResultService<bool> personResult = new ResultService<bool>();

            try
            {
                Person person = personRepository.Get(a => a.ID == people.ID);
                if (person == null)
                {
                    personResult.AddError("null hatası", "Bu guide sahip user yok");
                    return personResult;
                }

                person.Name = people.Name;

                Person updatePerson = personRepository.Update(person);

                if (updatePerson == null)
                {
                    personResult.AddError("update hatası", "Update başarılı değil");
                    return personResult;
                }

                personResult.Data = true;

                return personResult;



            }
            catch (Exception ex)
            {

                personResult.AddError("Exception", ex.Message);
                return personResult;
            }






        }

        public ResultService<PeopleScoreVM> GetToDoScore()
        {
            ResultService<PeopleScoreVM> resultService = new ResultService<PeopleScoreVM>();

            try
            {
                int resultPeople = personRepository.GetAll(a => a.IsActive).Count();


                var Total = new PeopleScoreVM()
                {
                    PeopleTotal=resultPeople   
                };

                resultService.Data= Total;



            }
            catch (Exception)
            {

                throw;
            }



            return resultService;
        }
    }
}
