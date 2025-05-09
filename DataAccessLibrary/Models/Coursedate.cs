
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Coursedate
    {
        [Key]
        [Display(Name = "کد برگزاری دوره")]
        public int CourseNumber { get; set; }

        [Display(Name = "کد دوره")]
        public int CourseId { get; set; }

        //[Display(Name = "عنوان دوره")]
        //public string Title { get; set; }

        //public bool RegisterSituation { get; set; }

        [Display(Name = "سال برگزاری")]
        //[Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public int Year { get; set; }


        [Display(Name = "مدت برگزاری")]
        //[Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public int Duration { get; set; }

        [Display(Name = "از تاریخ")]
        //[Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        public DateTime StartDate { get; set; }

        [Display(Name = "تا تاریخ")]
        //[Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        //[Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public bool IsDeleted { get; set; }
        public virtual Course course { get; set; }

        public virtual List<OstadCourse> ostadcourse2 { get; set; }

        //public virtual Coursedate coursedate { get; set; }
        public Coursedate()
        {

        }
        
    }
}
