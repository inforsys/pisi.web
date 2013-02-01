using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PisiWeb.Models;
using System.ServiceModel;
using Pisi.Payslip.Contract;
namespace PisiWeb.Controllers
{
    public class PayrollReportController : Controller
    {
        ChannelFactory<IPayslipChannel> cf;

        public PayrollReportController()
        {
            cf = new ChannelFactory<IPayslipChannel>("payslip");
        }

        private UserProfile UsrProfile
        {
            get
            {
                UserProfile userProfile = new UsersContext().UserProfiles.Where(u => u.UserName == this.User.Identity.Name).FirstOrDefault();
                return userProfile;
            }
        }

        public JsonResult Payroll(string id)
        {
            using (var ch = cf.CreateChannel())
            {
                Payroll result = ch.LoadPayrollForEmployee(UsrProfile.EmployeeId, id);

                return Json(result);
            }
        }

        public JsonResult Allowance(string periodId)
        {
            using (var ch = cf.CreateChannel())
            {
                IList<PayrollAllowance> result = ch.LoadPayrollAllowances(UsrProfile.EmployeeId, periodId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Deduction(string periodId)
        {
            using (var ch = cf.CreateChannel())
            {
                IList<PayrollDeduction> result = ch.LoadPayrollDeductions(UsrProfile.EmployeeId, periodId);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
    }
}