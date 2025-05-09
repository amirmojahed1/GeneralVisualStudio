using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    public class Academic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "کد مرتبه علمی")]
        public int RankID  { get; set; }


        [Display(Name = "مرتبه علمی استاد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string AcademicRank { get; set; }

        public bool IsDeleted { get; set; }
        public virtual List<Ostad> ostads4 { get; set; }
        public Academic()
        {

        }
    }
}
