using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PageGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Display(Name = "نام گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string GroupName { get; set; }

        //Navigation Property
        public virtual List<Page> Pages { get; set; }

        public PageGroup()
        {

        }

    }
}
