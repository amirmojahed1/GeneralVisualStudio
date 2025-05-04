using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class InformationForm
    {
        public int Id { get; set; }  // Primary key

        [Display(Name = "نام سرگروه")]
        public string Leader { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "مقدار")]
        public decimal Value { get; set; }  // Assuming numerical value

        [Display(Name = "کنترل مقدار")]
        public bool ValueControl { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int Priority { get; set; }  // Assuming priority levels (e.g., 1-5)

        [Display(Name = "وضعیت")]
        public string Status { get; set; }  // Assuming status values like "Active", "Pending", etc.
    }

}
