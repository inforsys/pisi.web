using System;
using System.Collections.Generic;

namespace Pisi.DataModel.Models
{
    public class tblUserVerification
    {
        public string EmployeeId { get; set; }
        public string VeryficationKey { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
    }
}
