using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;

namespace Pisi.MasterData.Services
{
   // public class Registration:IRegistrationService
    public partial class MasterDataServices : IRegistrationService
    {
        public VerificationEmployee GetEmployeeByVerificationKey(string key)
        {
            VerificationRepository repo = new VerificationRepository();
            return repo.LoadByKey(key);
        }
    }
}