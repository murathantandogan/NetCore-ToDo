using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.ViewModel.Enums;

namespace ToDo.ViewModel.ToDoItemViewModels
{
    public class ToDoItemEditVM
    {

        public int ID { get; set; }

        [Display(Name = "Görev Adı")]
        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Görev adı en az 10 en fazla 200 karakter olabilir.")]
        public string Subject { get; set; }


        [Display(Name = "Başlangıç Tarihi")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

       
        public StatusEnum Status { get; set; }



        [Display(Name = "Ek Notlar")]
        [Required]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Not en az 10 en fazla 500 karakter olabilir.")]
        public string Notes { get; set; }

        public int PersonID { get; set; }

        public string PersonName { get; set; }

       

    }
}
