namespace Virtualdars.DesignPatterns.Mediator
{
    public interface IUser
    {
        TelegramGroupMediator Mediator { get; set; }
        string Name { get; set; }

        void Send(string message, IUser receiver);
        void Receive(string message, IUser sender);
    }

    public class User : IUser
    {
        public User(TelegramGroupMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public TelegramGroupMediator Mediator { get; set; }
        public string Name { get; set; }

        public void Receive(string message, IUser sender)
        {
            Console.WriteLine($"{Name}ga {sender.Name}dan Habar keldi: {message}\n");
        }

        public void Send(string message, IUser receiver = null)
        {
            string receiverName = receiver == null ? "HAMMAGA" : receiver.Name;
            Console.WriteLine($"{Name} {receiverName}ga Habar jo'natyapti: {message}\n");
            Mediator.SendMessage(message, this, receiver);
        }
    }

}
