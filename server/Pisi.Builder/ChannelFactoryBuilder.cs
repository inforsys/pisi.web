using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Pisi.Payslip.Contract;
using Microsoft.ServiceBus;
using System.ServiceModel.Channels;
using Pisi.MasterData.Contract;

namespace Pisi.Builder
{
    public class ChannelFactoryBuilder
    {
        public static ChannelFactory<IPayslipChannel> CreatePayslipCF(string serviceNamespace, string accessKey)
        {
            ChannelFactory<IPayslipChannel> result = CFBuilder.For<IPayslipChannel>()
                .Url("payrollservices/payslip")
                .Issuer("owner")
                .Namespace(serviceNamespace)
                .AccessKey(accessKey)
                .Build();

            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, "payrollservices/payslip");

            ChannelFactory<IPayslipChannel> channelFactory = new ChannelFactory<IPayslipChannel>(new NetTcpRelayBinding(), new EndpointAddress(serviceUri));
            channelFactory.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior()
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", accessKey)
            });

            return channelFactory;
        }

        public static ChannelFactory<IRegistrationChannel> CreateRegistrationCF(string serviceNamespace, string accessKey)
        {
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, "payrollservices/signup");

            ChannelFactory<IRegistrationChannel> channelFactory = new ChannelFactory<IRegistrationChannel>(new NetTcpRelayBinding(), new EndpointAddress(serviceUri));
            channelFactory.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior()
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", accessKey)
            });

            return channelFactory;
        }
    }
}
