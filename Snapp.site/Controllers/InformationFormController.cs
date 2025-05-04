using Core.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Snapp.site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationFormController : GenericController<InformationForm>
    {
        public InformationFormController(IRepository<InformationForm> repository) : base(repository) { }
    }
}
