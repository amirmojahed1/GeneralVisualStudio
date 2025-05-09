using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    public class Employ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "کد وضعیت استخدام")]
        public int EmployID { get; set; }


        [Display(Name = "وضعیت استخدامی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string EmployName { get; set; }

        public bool IsDeleted { get; set; }
        public virtual List<Ostad> ostads6 { get; set; }
        public Employ()
        {

        }
    }
}

