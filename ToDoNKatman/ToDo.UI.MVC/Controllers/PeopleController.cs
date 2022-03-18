using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.BLL.Abstract;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.ViewModel.PeopleViewModels;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.UI.MVC.Controllers
{
    public class PeopleController : Controller
    {

        IPersonBLL _personService;

        public PeopleController(IPersonBLL personService)
        {
            _personService = personService;
        }



        public IActionResult Index()
        {

            ResultService<List<PeopleTotalVM>> result = _personService.GetPeopleAll();


            if (!result.HasError)
            {
                return View(result.Data);
            }
            else
            {
                ViewBag.Message = result.Errors[0].ErrorMessage;
                return View();
            }


        }

        public IActionResult Create()
        {

            ToDoItemCreateVM todoItem = new ToDoItemCreateVM();
           
            return View(todoItem);
        }


        [HttpPost]
        public IActionResult Create(PeopleCreateVM people)
        {
            if (ModelState.IsValid)
            {
                ResultService<PeopleCreateVM> resultService = _personService.Insert(people);
                return RedirectToAction(nameof(Index));
            }
            return View(people);
        }



        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            ResultService<PeopleTotalVM> resultService = _personService.Edit(id);

            var result = resultService.Data;
            return  View(result);
        }


        [HttpPost]
        public IActionResult Edit(PeopleTotalVM people)
        {
            if (ModelState.IsValid)
            {
                ResultService<bool> resultService = _personService.EditSave(people);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }




      






    }
}