namespace Virtualdars.DesignPatterns.Mediator
{
    public interface ITelegramGroupMediator
    {
        void SendMessage(string message, IUser sender, IUser receiver);
        void RegisterUser(IUser user);
    }


    public class TelegramGroupMediator : ITelegramGroupMediator
    {
        private List<IUser> _usersList = new();

        public void RegisterUser(IUser user)
        {
            _usersList.Add(user);
        }

        public void SendMessage(string message, IUser sender, IUser receiver = null)
        {
            if (receiver == null)
            {
                if (_usersList == null || _usersList.Count <= 0)
                {
                    Console.WriteLine("Guruhda hech kim yo'q!");
                }
                _usersList.ForEach(r => r.Receive("*HAMMAGA*:" + message, sender));
            }
            else
            {
                receiver.Receive("*SHAXSIY*:"+message, sender);
            }
        }
    }
}
