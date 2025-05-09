
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataAccessLibrary.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "کد دوره")]
        public int CourseId { get; set; }

        [Display(Name = "عنوان دوره")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public string Title { get; set; }


        [Display(Name = "موضوع")]
        //[Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public string Subject { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public bool Coursesituation { get; set; }

        public bool IsDeleted{ get; set; }

        public virtual List<Coursedate> coursedate { get; set; }

        public virtual List<OstadCourse> ostadcourse1 { get; set; }

        public Course()
        {

        }
    }
}

