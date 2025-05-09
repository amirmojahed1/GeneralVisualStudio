
using Core.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Snapp.site.Controllers
{
    public class AcademicController : GenericController<Academic>
    {
        public AcademicController(IRepository<Academic> repository) : base(repository) { }
    }
    public class OstadController : GenericController<Ostad>
    {
        public OstadController(IRepository<Ostad> repository) : base(repository) { }
    }
    public class CourseController : GenericController<Course>
    {
        public CourseController(IRepository<Course> repository) : base(repository) { }
    }
    public class CollegeController : GenericController<College>
    {
        public CollegeController(IRepository<College> repository) : base(repository) { }
    }
    public class CoursedateController : GenericController<Coursedate>
    {
        public CoursedateController(IRepository<Coursedate> repository) : base(repository) { }
    }
    public class EmployController : GenericController<Employ>
    {
        public EmployController(IRepository<Employ> repository) : base(repository) { }
    }
}
