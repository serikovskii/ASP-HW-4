using System.Linq;
using System.Web.Mvc;
using WebApplication5.DataAccess;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNews(Article response)
        {
            using (var context = new Context())
            {
                if(response.Text == null)
                {
                    return Json(context.News.ToList(), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var article = new Article
                    {
                        Title = response.Title,
                        Text = response.Text,
                        PathImage = response.PathImage
                    };

                    context.News.Add(article);
                    context.SaveChanges();

                    return Json(context.News.ToList(), JsonRequestBehavior.AllowGet);
                }
                
            }
        }
    }
}