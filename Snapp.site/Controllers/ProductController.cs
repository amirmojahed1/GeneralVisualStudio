using Core.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductController : GenericController<Page>
{
    public ProductController(IRepository<Page> repository) : base(repository) { }
}
