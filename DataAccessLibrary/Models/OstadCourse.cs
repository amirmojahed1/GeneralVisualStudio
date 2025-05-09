using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class OstadCourse
    {
        [Key]       
        public int OstadCourseId { get; set; }

       
        public int Id { get; set; }

        public bool RegisterSituation { get; set; }

        [Display(Name = "کد برگزاری دوره")]
        public int CourseNumber { get; set; }

        public bool IsDeleted { get; set; }


        public virtual Ostad Ostad14 { get; set; }
        public virtual Course Course14 { get; set; }

        public virtual Coursedate Coursedate14 { get; set; }

        public OstadCourse()
        {
        }

        public OstadCourse(int Id, int CourseNumber, bool RegisterSituation)
        {
            Id = Id;
            RegisterSituation = RegisterSituation;
            CourseNumber = CourseNumber;
        }
    }

}
