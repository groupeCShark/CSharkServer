using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using CSharkLibrary;

namespace CSharkServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class CSharkServiceImpl : ICSharkService
    {
        private readonly Dictionary<ICSharkClient, User> _users = new Dictionary<ICSharkClient, User>();

        public User[] LoggedUsers
        {
            get
            {
                return _users.Values.ToArray();
            }
        }

        public void Login(string username)
        {
            ICSharkClient connection = OperationContext.Current.GetCallbackChannel<ICSharkClient>();
            User user = new User { Username = username, LoginTime = DateTime.Now };
            _users[connection] = user;

            Console.WriteLine("{0} logged in.", username);
        }

        public void Logout()
        {
            ICSharkClient connection = OperationContext.Current.GetCallbackChannel<ICSharkClient>();
            User user;
            if (_users.TryGetValue(connection, out user))
            {
                Console.WriteLine("{0} logged out.", user.Username);
                _users.Remove(connection);
            }
        }

        public void SendMessage(string message)
        {
            ICSharkClient connection = OperationContext.Current.GetCallbackChannel<ICSharkClient>();
            User user;

            if (!_users.TryGetValue(connection, out user))
                return;

            foreach (ICSharkClient otherConnection in _users.Keys)
            {
                if (otherConnection == connection)
                    continue;
                otherConnection.ReceiveMessage(user.Username, message);
            }
        }
    }
}
