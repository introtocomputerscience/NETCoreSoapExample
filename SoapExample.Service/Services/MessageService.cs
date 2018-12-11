using System;
using System.Linq;

namespace SoapExample.Service
{
    public class MessageService : IMessageService
    {
        public string Reverse(string message)
        {
            return new string(message.Reverse().ToArray());
        }
    }
}