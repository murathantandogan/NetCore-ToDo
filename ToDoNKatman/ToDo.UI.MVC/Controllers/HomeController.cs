using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.BLL.Abstract;
using ToDo.BLL.Concrete.ResultSeviceBLL;
using ToDo.ViewModel.HomeViewModels;
using ToDo.ViewModel.PeopleViewModels;
using ToDo.ViewModel.ToDoItemViewModels;

namespace ToDo.UI.MVC.Controllers
{

    public class HomeController : Controller
    {
        IToDoItemBLL _toDoService;
        IPersonBLL _personService;

        public HomeController(IToDoItemBLL toDoService, IPersonBLL personService)
        {
            _toDoService = toDoService;
            _personService = personService;

        }
        public IActionResult Index()
        {


            ResultService<List<ToDoItemScoreVM>> resultToDo = _toDoService.GetToDoScore();

            ResultService<PeopleScoreVM> resultPeople = _personService.GetToDoScore();

            ViewBag.ToDoToTal = resultToDo;
            ViewBag.UserToTal = resultPeople;

           


          


            return View();
        }
    }
}
