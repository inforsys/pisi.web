using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PisiWeb.Models;
using System.ServiceModel;
using Pisi.MasterData.Contract;

namespace PisiWeb.Controllers
{
    public class SignupVerificationController : Controller
    {
        //
        // GET: /SignupVerification/

        [HttpPost]
        public JsonResult VerifyRegistrationId(RegistrationId regModel)
        {
            try
            {
                var cf = new ChannelFactory<IRegistrationService>("signup");
                var ch = cf.CreateChannel();
                VerificationEmployee result = ch.GetEmployeeByVerificationKey(regModel.regId);
                if (result == null)
                    throw new ApplicationException("Invalid registration id.");
                
                Session["UserProfile"] = result;
                
                return Json(new { 
                    EmployeeId = result.EmployeeId,
                    EmployeeName = result.Name,
                    BirthDate = result.BirthDate.Value.ToString("dd-MM-yyyy"),
                    BirthPlace = result.BirthPlace,
                    Address = result.Address
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}