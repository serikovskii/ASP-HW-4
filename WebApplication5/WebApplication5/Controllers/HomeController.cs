using System.Linq;
using System.Web.Mvc;
using WebApplication5.DataAccess;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using(var context = new Context())
            {
                ViewBag.News = context.News.ToList();
            }
            return View();
        }
    }
}