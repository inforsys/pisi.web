using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PisiWeb.Models;

namespace PisiWeb.App_Start
{
    public class SecurityDBInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            base.Seed(context);
        }
    }
}