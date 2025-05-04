using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }
        [Display(Name = "گروه صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public int GroupID { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public string Title { get; set; }
        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public string ShortDescription { get; set; }
        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public string Text { get; set; }
        [Display(Name = "بازدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public int visit { get; set; }
        [Display(Name = "تصویر")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public string ImageName { get; set; }
        [Display(Name = "اسلایدر")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public bool ShowInSlider { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید. ")]
        public DateTime CreateDate { get; set; }

        public virtual PageGroup PageGroup { get; set; }

        public virtual List<PageComment> PageComments { get; set; }
        public Page()
        {

        }


    }
}
