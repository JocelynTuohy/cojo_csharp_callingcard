using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingcard.Controllers
{
    public class CallingCardController : Controller
    {
        [HttpGet]
        [Route("")]
        public JsonResult Name()
        {
            return Json("Jocelyn");
        }

        [HttpGet]
        [Route("age")]
        public JsonResult Age()
        {
            return Json(33);
        }

        [HttpGet]
        [Route("{firstName}/{lastName}/{age}/{faveColor}")]
        public JsonResult Jsonify(string firstName, string lastName, int age, string faveColor)
        {
          var callCard = new {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            FaveColor = faveColor
          };
          return Json(callCard);
        }

        [HttpGet]
        [Route("bonus")]
        public IActionResult Index()
        {
            return View();
        }
    }
}