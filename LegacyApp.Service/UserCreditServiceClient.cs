using LegacyApp.Service.Interface;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace LegacyApp.Service
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class UserCreditServiceClient : ClientBase<IUserCreditService>, IUserCreditService
    {
        private IUserCreditServiceChannel _userCreditServiceChannelImplementation;
        public UserCreditServiceClient() { }

        public UserCreditServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        { }

        public UserCreditServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        { }

        public UserCreditServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        { }

        public int GetCreditLimit(string firstname, string surname, DateTime dateOfBirth)
        {
            return base.Channel.GetCreditLimit(firstname, surname, dateOfBirth);
        }
    }
}
