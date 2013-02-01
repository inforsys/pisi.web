using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using Pisi.MasterData.Contract;
using Pisi.Payslip.Contract;
using PisiWeb.Models;

namespace PisiWeb.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            try
            {
                var cf = new ChannelFactory<IPayslipChannel>("payslip");
                IList<PayslipPeriod> result = new List<PayslipPeriod>();

                UserProfile userProfile = new UsersContext().UserProfiles.Where(u => u.UserName == this.User.Identity.Name).FirstOrDefault();

                using (var ch = cf.CreateChannel())
                {
                    result = ch.FindAllPublishedPeriodForEmployee(userProfile.EmployeeId);
                }

                return View(result);
            }
            catch (Exception ex)
            {
                return View(new List<PayslipPeriod>());
            }
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