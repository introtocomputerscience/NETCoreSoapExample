using System;
using System.ServiceModel;

namespace SoapExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Write("Please enter a message: ");
                var message = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(message))
                {
                    running = false;
                    continue;
                }
                var reversedMessage = ReverseMessage(message);
                Console.WriteLine($"Your message reversed is: {reversedMessage}");
            }
        }

        internal static string ReverseMessage(string message)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri("http://localhost:5000/MessageService.svc"));
            var channelFactory = new ChannelFactory<IMessageService>(binding, endpoint);
            var serviceClient = channelFactory.CreateChannel();
            var result = serviceClient.Reverse(message);
            channelFactory.Close();
            return result;
        }
    }
}
