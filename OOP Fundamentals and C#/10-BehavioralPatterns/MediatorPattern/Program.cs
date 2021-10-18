using System;
using System.IO;

namespace MediatorPattern
{
    record MessageRequest(string Message) : IRequest;
    class MessageHandler : IRequestHandler<MessageRequest>
    {
        public void Handle(MessageRequest request)
        {
            Console.WriteLine($"Sending message {request.Message}");
        }
    }

    record NumberRequest(int Value) : IRequest;
    class NumberHandler : IRequestHandler<NumberRequest>
    {
        public void Handle(NumberRequest request)
        {
            File.WriteAllLines("./hello.txt", new string[] { $"Sending number {request.Value}" });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            mediator.RegisterHandler(typeof(MessageRequest), new MessageHandler());
            mediator.RegisterHandler(typeof(NumberRequest), new NumberHandler());

            mediator.Send(new NumberRequest(154));
        }
    }
}
