using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        [Route("callingcard")]
        public JsonResult CallingCard()
        {
            var CardObject = new {
                FirstName = "Tim",
                LastName = "Toolman",
                Age = 42,
                FavoriteColor = "Brown"
            };
            return Json(CardObject);
        }
    }
}