
using Core.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Snapp.site.Controllers
{
    public class ParameterController : GenericController<Parameter>
    {
        public ParameterController(IRepository<Parameter> repository) : base(repository) { }
    }
}
