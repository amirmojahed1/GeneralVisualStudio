using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class AdminLogin
    {
        [Key]
        public int LoginID { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        public string Family { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        [MaxLength(200)]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        [MaxLength(250)]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را مشخص کنید")]
        [MaxLength(200)]
        public string Password { get; set; }

        public string Control { get; set; }
        public string ActiveCode {  get; set; }
        public bool IsActive { get; set; }

        public  bool Islogin{ get; set; }

        public int RoleID { get; set; }
        public virtual Roles role { get; set; }

    }

}

