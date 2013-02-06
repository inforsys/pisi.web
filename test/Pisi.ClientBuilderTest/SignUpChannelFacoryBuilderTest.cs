using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.Builder;
using System.ServiceModel;
using Pisi.Payslip.Contract;
using Pisi.MasterData.Contract;
namespace Pisi.ClientBuilderTest
{
    [TestClass]
    public class SignUpChannelFacoryBuilderTest
    {
         static ChannelFactory<IRegistrationChannel> cf;
        [ClassInitialize()]
         public static void Init(TestContext testContext)
        {
            cf = ChannelFactoryBuilder.CreateRegistrationCF("pisisb1", "GENQ58IisBo7uTnjKlIRX0698ZYQ5ZhDUCkOkD9E50E=");
           // cf = ChannelFactoryBuilder.CreateRegistrationCF("faturtest1", "cIdkZ0Fo6rM2AEADszEi81LL4ySCt/sqiP7qHr40W2A=");
        }
        [TestMethod]
        public void TestCreateFactory()
        {
            Assert.IsNotNull(cf);
        }
        [TestMethod]
        public void TestCreateChannerl()
        {
            using (var ch = cf.CreateChannel())
            {
                Assert.IsNotNull(ch);
            }
        }

        [TestMethod]
        public void TestCallMethodFromChannel()
        {
            using (var ch = cf.CreateChannel())
            {
                var emp = ch.GetEmployeeByVerificationKey("0007VT1");
                Console.WriteLine("Name: {0}, Address:{1}", emp.Name, emp.Address);
               
            }
        }
        [ClassCleanup()]
        public static void Cleanup() {
            cf.Close();
        }
    }
}
