using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.ViewModel.PeopleViewModels
{
    public class PeopleCreateVM
    {


        [Display(Name = "Name", Prompt = "name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "max 100 character", MinimumLength = 2)]
        public string Name { get; set; }
    }
}
