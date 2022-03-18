using System;
using System.ComponentModel.DataAnnotations;
using ToDo.ViewModel.Enums;

namespace ToDo.ViewModel.ToDoItemViewModels
{

    public class ToDoItemCreateVM
    {
        public ToDoItemCreateVM()
        {
            this.Status = StatusEnum.ToDo;
            this.StartDate = DateTime.Now.Date;
        }
       

        [Display(Name = "Görev Adı")]
        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Görev adı en az 10 en fazla 200 karakter olabilir.")]
        public string Subject { get; set; }


        [Display(Name = "Başlangıç Tarihi")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } 


        [Display(Name = "Görev Durumu")]
        [Required]
        public StatusEnum Status { get; set; }


        [Display(Name = "Ek Notlar")]
        public string Notes { get; set; }


        [Display(Name = "Personel ID")]
        public int PersonID { get; set; }



    }
}
