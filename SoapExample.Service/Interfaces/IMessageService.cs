using System.ServiceModel;

namespace SoapExample.Service
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        string Reverse(string message);
    }
}