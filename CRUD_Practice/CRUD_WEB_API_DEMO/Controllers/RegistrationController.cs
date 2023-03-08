using CRUD_WEB_API_DEMO.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_WEB_API_DEMO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly RegistrationAPIDbContext dbContext;

        public ContactsController(RegistrationAPIDbContext dbContext)
        {

            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetContacts()
        {

            return Ok(dbContext.Contacts.ToList());
        }
    }
}
