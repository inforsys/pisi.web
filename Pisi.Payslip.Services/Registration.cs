using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;
using Pisi.MasterData;

namespace Pisi.Services
{
   // public class Registration:IRegistrationService
    public partial class PisiServices : IRegistrationService
    {
        public VerificationEmployee GetEmployeeByVerificationKey(string key)
        {
            VerificationRepository repo = new VerificationRepository();
            return repo.LoadByKey(key);
        }
    }
}