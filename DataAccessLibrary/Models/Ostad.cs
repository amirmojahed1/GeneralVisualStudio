using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Ostad
    {
        [Key]
        [Display(Name = "کد ")]
        public int Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string OstadName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string OstadFamily { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "کد استاد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public int OstadId { get; set; }

        [Display(Name = "شماره تلفن")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Phone { get; set; }

        [Display(Name = "نام پدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Father { get; set; }

        [Display(Name = " تلفن همراه")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string PhonNumber { get; set; }

        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Kodmelli { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "لطفا ایمیل معتبر وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public bool Gender { get; set; }

        [Display(Name = "وضعیت استاد")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public int EmployID { get; set; }

        [Display(Name = "مرتبه علمی")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public int RankID  { get; set; }
        [Display(Name = "دانشکده")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        public int CollegeID { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Employ employ { get; set; }

        public virtual Academic academic { get; set; }

        public virtual College college { get; set; }

        
        public virtual ICollection<OstadCourse> OstadCourses2 { get; set; }
        public Ostad()
        {

        }

    }
}
