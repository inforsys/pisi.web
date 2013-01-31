using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Pisi.MasterData.Contract
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IPeriodService
    {
        [OperationContract]
        IList<PayrollPeriod> FindAllPublishedPeriod();
    }
    public interface IPeriodChannel : IPeriodService, IClientChannel { }
}
