using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using Pisi.MasterData.Contract;

namespace PisiWeb.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            var cf = new ChannelFactory<IPayslipChannel>("payslip");
            IList<PayrollPeriod> result = new List<PayrollPeriod>();
            
            using (var ch = cf.CreateChannel())
            {
                //int test = ch.AddNumbers(3, 4);
                result = ch.FindAllPublishedPeriod();
            }

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}