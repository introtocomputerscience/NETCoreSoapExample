using System.ServiceModel;

namespace SoapExample.Client
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        string Reverse(string message);
    }
}