using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pisi.Payslip.Contract;
using System.ServiceModel;
using PisiWeb.Models;
namespace PisiWeb.Controllers
{
    public class PayrollController : ApiController
    {
        public Payroll Get(string id)
        {
            UserProfile userProfile = new UsersContext().UserProfiles.Where(u => u.UserName == this.User.Identity.Name).FirstOrDefault();

            var cf = new ChannelFactory<IPayslipChannel>("payslip");
            using (var ch = cf.CreateChannel())
            {
                //int test = ch.AddNumbers(3, 4);
                Payroll result = ch.LoadPayrollForEmployee(userProfile.EmployeeId, id);

                return result;
            }
        }
    }
}