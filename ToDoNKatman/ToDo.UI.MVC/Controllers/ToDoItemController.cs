using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.BLL.Abstract;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.ViewModel.PeopleViewModels;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.UI.MVC.Controllers
{
    public class ToDoItemController : Controller
    {
        IToDoItemBLL _toDoService;
        IPersonBLL _personService;

        public ToDoItemController(IToDoItemBLL toDoService, IPersonBLL personService)
        {
            _toDoService = toDoService;
            _personService = personService;


        }


        public IActionResult Index()
        {
            ResultService<List<ToDoItemTotalVm>> result = _toDoService.GetToDoAll();


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
            ResultService<List<PeopleTotalVM>> result = _personService.GetPeopleAll();
            ViewData["PersonID"] = new SelectList(result.Data, "ID", "Name");
            return View();
        }



        [HttpPost]
        public IActionResult Create(ToDoItemCreateVM toDoItem)
        {
            if (ModelState.IsValid)
            {
                ResultService<ToDoItemCreateVM> result = _toDoService.Create(toDoItem);
                return RedirectToAction(nameof(Index));
            }
            ResultService<List<PeopleTotalVM>> people = _personService.GetPeopleAll();
            ViewData["PersonID"] = new SelectList(people.Data, "ID", "Name");
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ResultService<ToDoItemEditVM> resultService = _toDoService.Edit(id);

            var result = resultService.Data;

            ResultService<List<PeopleTotalVM>> people = _personService.GetPeopleAll();
            ViewData["PersonID"] = new SelectList(people.Data, "ID", "Name");
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ToDoItemEditVM toDoItem)
        {

            if (ModelState.IsValid)
            {
                ResultService<bool> result = _toDoService.EditSave(toDoItem);
                return RedirectToAction(nameof(Index));
            }


            ResultService<List<PeopleTotalVM>> people = _personService.GetPeopleAll();
            ViewData["PersonID"] = new SelectList(people.Data, "ID", "Name");
            return View();

        }





        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ResultService<ToDoItemEditVM> resultService = _toDoService.Edit(id);

            var result = resultService.Data;

            ResultService<List<PeopleTotalVM>> people = _personService.GetPeopleAll();
            ViewData["PersonID"] = new SelectList(people.Data, "ID", "Name");
            return View(result);
        }













    }
}
