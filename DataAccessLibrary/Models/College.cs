using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class College
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "کد دانشکده")]

        public int CollegeID { get; set; }

        [Display(Name = " دانشکده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string CollegeName { get; set; }

        public bool IsDeleted { get; set; }
        public virtual List<Ostad> ostads5 { get; set; }
        public College()
        {

        }
    }
}
