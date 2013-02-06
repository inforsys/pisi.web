using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.Builder;
using System.ServiceModel;
using Pisi.Payslip.Contract;
namespace Pisi.ClientBuilderTest
{
    [TestClass]
    public class PayslipChannelFacoryBuilderTest
    {
         static ChannelFactory<IPayslipChannel> cf;
        [ClassInitialize()]
         public static void Init(TestContext testContext)
        {
            //cf = ChannelFactoryBuilder.CreatePayslipCF("pisisb1", "GENQ58IisBo7uTnjKlIRX0698ZYQ5ZhDUCkOkD9E50E=");
            cf = ChannelFactoryBuilder.CreatePayslipCF("faturtest1", "cIdkZ0Fo6rM2AEADszEi81LL4ySCt/sqiP7qHr40W2A=");
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
                foreach (var p in ch.FindAllPublishedPeriodForEmployee("0007"))
                {
                    Console.WriteLine("Id : {0}, Name: {1}", p.Code, p.Name);
                }
               
            }
        }
        [ClassCleanup()]
        public static void Cleanup() {
            cf.Close();
        }
    }
}
