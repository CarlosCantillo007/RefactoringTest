using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace LegacyApp.Service.Interface
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "LegacyApp.IUserCreditService")]
    public interface IUserCreditService
    {
        [OperationContract(Action = "http://totally-real-service.com/IUserCreditService/GetCreditLimit")]
        int GetCreditLimit(string firstname, string surname, DateTime dateOfBirth);
    }
}
